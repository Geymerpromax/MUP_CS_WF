using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MUP_CS_WF
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
            LoginField.ForeColor = Color.Gray;
            LoginField.Text = "Введите имя";
            PasswordField.UseSystemPasswordChar = false;
            PasswordField.ForeColor = Color.Gray;
            PasswordField.Text = "Введите пароль";
            ActiveControl = null;
        }

        //
        // ButtonClose
        //
        private void ButtonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void ButtonClose_MouseEnter(object sender, EventArgs e)
        {
            ButtonClose.BackColor = Color.HotPink;
        }
        private void ButtonClose_MouseLeave(object sender, EventArgs e)
        {
            ButtonClose.BackColor = Color.White;
        }
        //
        // ButtonMinimaze
        //
        private void ButtonMinimaze_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
            ButtonMinimaze.BackColor = Color.White;
            Panel.Visible = false;
        }
        private void ButtonMinimaze_MouseEnter(object sender, EventArgs e)
        {
            ButtonMinimaze.BackColor = Color.HotPink;
        }
        private void ButtonMinimaze_MouseLeave(object sender, EventArgs e)
        {
            ButtonMinimaze.BackColor = Color.White;
        }
        //
        // TopPanel
        //
        Point lastPoint = new Point();
        private void TopPanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }
        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }
        private void TopPanel_Click(object sender, EventArgs e)
        {
            Panel.Visible = false;
        }
        //
        // PanelFieldOne
        //
        private void PanelFieldOne_MouseEnter(object sender, EventArgs e)
        {
            PanelFieldOne.BackColor = Color.HotPink;
        }

        private void PanelFieldOne_MouseLeave(object sender, EventArgs e)
        {
            PanelFieldOne.BackColor = Color.White;
        }
        //
        // IcoButton
        //
        private void IcoButton_Click(object sender, EventArgs e)
        {
            Panel.Visible = true;
        }
        //
        // MainPanel
        //
        private void MainPanel_Click(object sender, EventArgs e)
        {
            Panel.Visible = false;
        }
        //
        // Title
        //
        private void Title_Click(object sender, EventArgs e)
        {
            Panel.Visible = false;
        }
        //
        // pictureBox
        //
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Panel.Visible = false;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Panel.Visible = false;
        }
        //
        // PasswordField
        //
        private void PasswordField_Click(object sender, EventArgs e)
        {
            Panel.Visible = false;
        }
        private void PasswordField_Enter(object sender, EventArgs e)
        {
            label2.Visible = false;
            if (PasswordField.Text == "Введите пароль")
            {
                PasswordField.Text = "";
                PasswordField.ForeColor = Color.Black;
                PasswordField.UseSystemPasswordChar = true;
            }
        }
        private void PasswordField_Leave(object sender, EventArgs e)
        {
            if (PasswordField.Text == "")
            {
                PasswordField.Text = "Введите пароль";
                PasswordField.ForeColor = Color.Gray;
                PasswordField.UseSystemPasswordChar = false;
            }
        }
        //
        // ButtonLogin
        //
        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            Panel.Visible = false;
            if (PasswordField.Text == "Введите пароль")
            {
                label2.Visible = true;
            }
            if (LoginField.Text == "Введите имя")
            {
                label1.Visible = true;
            }
            if (LoginField.Text != "Введите имя" || (PasswordField.Text != "Введите пароль"))
            {
                if(CheckLogin())
                {
                    return;
                }
                DB db = new DB();
                MySqlCommand command = new MySqlCommand
                    (
                    "INSERT INTO `users` (`login`, `pass`) " +
                    "VALUES (@login, @pass);", db.GetConnection()
                    );

                command.Parameters.Add("@login", MySqlDbType.VarChar).Value = LoginField.Text;
                command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = PasswordField.Text;
                db.OpenConnection();

                if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт создан");
                }
                else
                {
                    MessageBox.Show("Аккаунт не создан");
                }

                db.CloseConnection();
            }
           


            
          
        }
        //
        // LoginField
        //
        private void LoginField_Click(object sender, EventArgs e)
        {
            Panel.Visible = false;
            LoginField.Enabled = true;
        }

        private void LoginField_Enter(object sender, EventArgs e)
        {
            label1.Visible = false;
            if (LoginField.Text == "Введите имя")
            {
                LoginField.Text = "";
                LoginField.ForeColor = Color.Black;
            }
        }
        private void LoginField_Leave(object sender, EventArgs e)
        {
            if (LoginField.Text == "")
            {
                LoginField.Text = "Введите имя";
                LoginField.ForeColor = Color.Gray;
            }
        }

        private void LoginField_MouseEnter(object sender, EventArgs e)
        {

        }
        private void LoginField_MouseLeave(object sender, EventArgs e)
        {
           
        }
        //
        //
        //   

        public bool CheckLogin()
        {
            DB db = new DB();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand
                (
                "SELECT * FROM `users` WHERE  `login` = @uL", db.GetConnection()
                );
            command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = LoginField.Text;
            
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (table.Rows.Count > 0)
            {
                MessageBox.Show("Пользователь c таким логином уже существует.");
                return true;
            }
            else
            {
                return false;
            }
               
        }
    }
}
