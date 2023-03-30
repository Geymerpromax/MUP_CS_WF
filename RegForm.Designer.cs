namespace MUP_CS_WF
{
    partial class RegForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegForm));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.Panel = new System.Windows.Forms.Panel();
            this.PanelFieldTwo = new System.Windows.Forms.Label();
            this.PanelFieldOne = new System.Windows.Forms.Label();
            this.IcoButton = new System.Windows.Forms.PictureBox();
            this.ButtonMinimaze = new System.Windows.Forms.PictureBox();
            this.ButtonClose = new System.Windows.Forms.PictureBox();
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.PasswordField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.LoginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TopPanel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.MainPanel.SuspendLayout();
            this.Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcoButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimaze)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.MediumPurple;
            this.MainPanel.Controls.Add(this.Panel);
            this.MainPanel.Controls.Add(this.IcoButton);
            this.MainPanel.Controls.Add(this.ButtonMinimaze);
            this.MainPanel.Controls.Add(this.ButtonClose);
            this.MainPanel.Controls.Add(this.ButtonLogin);
            this.MainPanel.Controls.Add(this.Title);
            this.MainPanel.Controls.Add(this.PasswordField);
            this.MainPanel.Controls.Add(this.pictureBox2);
            this.MainPanel.Controls.Add(this.LoginField);
            this.MainPanel.Controls.Add(this.pictureBox1);
            this.MainPanel.Controls.Add(this.TopPanel);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Cursor = System.Windows.Forms.Cursors.Default;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(460, 480);
            this.MainPanel.TabIndex = 0;
            this.MainPanel.Click += new System.EventHandler(this.MainPanel_Click);
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.White;
            this.Panel.Controls.Add(this.PanelFieldTwo);
            this.Panel.Controls.Add(this.PanelFieldOne);
            this.Panel.Location = new System.Drawing.Point(0, 51);
            this.Panel.Name = "Panel";
            this.Panel.Size = new System.Drawing.Size(160, 80);
            this.Panel.TabIndex = 10;
            this.Panel.Visible = false;
            // 
            // PanelFieldTwo
            // 
            this.PanelFieldTwo.BackColor = System.Drawing.Color.White;
            this.PanelFieldTwo.Location = new System.Drawing.Point(0, 40);
            this.PanelFieldTwo.Name = "PanelFieldTwo";
            this.PanelFieldTwo.Size = new System.Drawing.Size(161, 40);
            this.PanelFieldTwo.TabIndex = 1;
            this.PanelFieldTwo.Text = "Выход";
            this.PanelFieldTwo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PanelFieldOne
            // 
            this.PanelFieldOne.BackColor = System.Drawing.Color.White;
            this.PanelFieldOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PanelFieldOne.Location = new System.Drawing.Point(0, 0);
            this.PanelFieldOne.Name = "PanelFieldOne";
            this.PanelFieldOne.Size = new System.Drawing.Size(161, 40);
            this.PanelFieldOne.TabIndex = 0;
            this.PanelFieldOne.Text = "Свойства";
            this.PanelFieldOne.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PanelFieldOne.MouseEnter += new System.EventHandler(this.PanelFieldOne_MouseEnter);
            this.PanelFieldOne.MouseLeave += new System.EventHandler(this.PanelFieldOne_MouseLeave);
            // 
            // IcoButton
            // 
            this.IcoButton.BackColor = System.Drawing.Color.White;
            this.IcoButton.Image = global::MUP_CS_WF.Properties.Resources._728934_enter_login_right_arrow_forward_icon;
            this.IcoButton.Location = new System.Drawing.Point(0, 0);
            this.IcoButton.Name = "IcoButton";
            this.IcoButton.Size = new System.Drawing.Size(50, 50);
            this.IcoButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IcoButton.TabIndex = 9;
            this.IcoButton.TabStop = false;
            this.IcoButton.Click += new System.EventHandler(this.IcoButton_Click);
            // 
            // ButtonMinimaze
            // 
            this.ButtonMinimaze.BackColor = System.Drawing.Color.White;
            this.ButtonMinimaze.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonMinimaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMinimaze.Image = ((System.Drawing.Image)(resources.GetObject("ButtonMinimaze.Image")));
            this.ButtonMinimaze.Location = new System.Drawing.Point(360, 0);
            this.ButtonMinimaze.Name = "ButtonMinimaze";
            this.ButtonMinimaze.Size = new System.Drawing.Size(50, 50);
            this.ButtonMinimaze.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonMinimaze.TabIndex = 7;
            this.ButtonMinimaze.TabStop = false;
            this.ButtonMinimaze.Click += new System.EventHandler(this.ButtonMinimaze_Click);
            this.ButtonMinimaze.MouseEnter += new System.EventHandler(this.ButtonMinimaze_MouseEnter);
            this.ButtonMinimaze.MouseLeave += new System.EventHandler(this.ButtonMinimaze_MouseLeave);
            // 
            // ButtonClose
            // 
            this.ButtonClose.BackColor = System.Drawing.Color.White;
            this.ButtonClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ButtonClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClose.Image = ((System.Drawing.Image)(resources.GetObject("ButtonClose.Image")));
            this.ButtonClose.Location = new System.Drawing.Point(410, 0);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(50, 50);
            this.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonClose.TabIndex = 6;
            this.ButtonClose.TabStop = false;
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            this.ButtonClose.MouseEnter += new System.EventHandler(this.ButtonClose_MouseEnter);
            this.ButtonClose.MouseLeave += new System.EventHandler(this.ButtonClose_MouseLeave);
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.FlatAppearance.BorderSize = 2;
            this.ButtonLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DeepSkyBlue;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.Transparent;
            this.ButtonLogin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ButtonLogin.Location = new System.Drawing.Point(147, 407);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(158, 49);
            this.ButtonLogin.TabIndex = 1;
            this.ButtonLogin.Text = "Готово";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // Title
            // 
            this.Title.BackColor = System.Drawing.Color.MediumPurple;
            this.Title.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Title.ForeColor = System.Drawing.Color.Bisque;
            this.Title.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Title.Location = new System.Drawing.Point(0, 51);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(460, 144);
            this.Title.TabIndex = 0;
            this.Title.Text = "Регистрация";
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Title.Click += new System.EventHandler(this.Title_Click);
            // 
            // PasswordField
            // 
            this.PasswordField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PasswordField.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PasswordField.Location = new System.Drawing.Point(105, 305);
            this.PasswordField.MaximumSize = new System.Drawing.Size(310, 57);
            this.PasswordField.MaxLength = 10;
            this.PasswordField.MinimumSize = new System.Drawing.Size(310, 57);
            this.PasswordField.Multiline = true;
            this.PasswordField.Name = "PasswordField";
            this.PasswordField.Size = new System.Drawing.Size(310, 57);
            this.PasswordField.TabIndex = 3;
            this.PasswordField.UseSystemPasswordChar = true;
            this.PasswordField.Click += new System.EventHandler(this.PasswordField_Click);
            this.PasswordField.Enter += new System.EventHandler(this.PasswordField_Enter);
            this.PasswordField.Leave += new System.EventHandler(this.PasswordField_Leave);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::MUP_CS_WF.Properties.Resources._9004738_lock_security_padlock_secure_icon;
            this.pictureBox2.Location = new System.Drawing.Point(12, 305);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 57);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // LoginField
            // 
            this.LoginField.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LoginField.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LoginField.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoginField.Location = new System.Drawing.Point(105, 221);
            this.LoginField.MaximumSize = new System.Drawing.Size(310, 57);
            this.LoginField.MaxLength = 10;
            this.LoginField.MinimumSize = new System.Drawing.Size(310, 57);
            this.LoginField.Multiline = true;
            this.LoginField.Name = "LoginField";
            this.LoginField.Size = new System.Drawing.Size(310, 57);
            this.LoginField.TabIndex = 2;
            this.LoginField.Click += new System.EventHandler(this.LoginField_Click);
            this.LoginField.Enter += new System.EventHandler(this.LoginField_Enter);
            this.LoginField.Leave += new System.EventHandler(this.LoginField_Leave);
            this.LoginField.MouseEnter += new System.EventHandler(this.LoginField_MouseEnter);
            this.LoginField.MouseLeave += new System.EventHandler(this.LoginField_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MUP_CS_WF.Properties.Resources._85408_user_yellow_icon;
            this.pictureBox1.Location = new System.Drawing.Point(12, 221);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 57);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TopPanel
            // 
            this.TopPanel.BackColor = System.Drawing.Color.White;
            this.TopPanel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TopPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 31.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopPanel.ForeColor = System.Drawing.Color.LightCoral;
            this.TopPanel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TopPanel.Location = new System.Drawing.Point(44, 0);
            this.TopPanel.Margin = new System.Windows.Forms.Padding(0);
            this.TopPanel.Name = "TopPanel";
            this.TopPanel.Size = new System.Drawing.Size(316, 50);
            this.TopPanel.TabIndex = 0;
            this.TopPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopPanel.Click += new System.EventHandler(this.TopPanel_Click);
            this.TopPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseDown);
            this.TopPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPanel_MouseMove);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(104, 304);
            this.label2.MaximumSize = new System.Drawing.Size(312, 59);
            this.label2.MinimumSize = new System.Drawing.Size(312, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(312, 59);
            this.label2.TabIndex = 11;
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(104, 220);
            this.label1.MaximumSize = new System.Drawing.Size(312, 59);
            this.label1.MinimumSize = new System.Drawing.Size(312, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(312, 59);
            this.label1.TabIndex = 12;
            this.label1.Text = "label2";
            this.label1.Visible = false;
            // 
            // RegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 480);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(460, 480);
            this.MinimumSize = new System.Drawing.Size(460, 480);
            this.Name = "RegForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginForm";
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IcoButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimaze)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label PanelFieldTwo;
        private System.Windows.Forms.Panel MainPanel;
        public System.Windows.Forms.Panel Panel;
        private System.Windows.Forms.Label PanelFieldOne;
        private System.Windows.Forms.PictureBox IcoButton;
        private System.Windows.Forms.PictureBox ButtonMinimaze;
        private System.Windows.Forms.PictureBox ButtonClose;
        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox PasswordField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox LoginField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label TopPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}