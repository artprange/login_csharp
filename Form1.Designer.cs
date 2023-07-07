namespace login
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            greeting = new Label();
            username = new Label();
            pw = new Label();
            txt_username = new TextBox();
            txt_password = new TextBox();
            btn_login = new Button();
            btn_clear = new Button();
            btn_exit = new Button();
            SuspendLayout();
            // 
            // greeting
            // 
            greeting.AutoSize = true;
            greeting.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            greeting.Location = new Point(125, 85);
            greeting.Name = "greeting";
            greeting.Size = new Size(125, 29);
            greeting.TabIndex = 0;
            greeting.Text = "Welcome!";
            greeting.Click += label1_Click;
            // 
            // username
            // 
            username.AutoSize = true;
            username.Location = new Point(55, 155);
            username.Name = "username";
            username.Size = new Size(63, 15);
            username.TabIndex = 1;
            username.Text = "Username:";
            // 
            // pw
            // 
            pw.AutoSize = true;
            pw.Location = new Point(58, 215);
            pw.Name = "pw";
            pw.Size = new Size(60, 15);
            pw.TabIndex = 2;
            pw.Text = "Password:";
            // 
            // txt_username
            // 
            txt_username.Location = new Point(125, 152);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(164, 23);
            txt_username.TabIndex = 3;
            // 
            // txt_password
            // 
            txt_password.Location = new Point(125, 215);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(164, 23);
            txt_password.TabIndex = 4;
            // 
            // btn_login
            // 
            btn_login.Location = new Point(125, 261);
            btn_login.Name = "btn_login";
            btn_login.Size = new Size(164, 23);
            btn_login.TabIndex = 5;
            btn_login.Text = "Login";
            btn_login.UseVisualStyleBackColor = true;
            btn_login.Click += btn_login_Click;
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(125, 302);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(75, 23);
            btn_clear.TabIndex = 6;
            btn_clear.Text = "Clear";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += button2_Click;
            // 
            // btn_exit
            // 
            btn_exit.Location = new Point(214, 302);
            btn_exit.Name = "btn_exit";
            btn_exit.Size = new Size(75, 23);
            btn_exit.TabIndex = 7;
            btn_exit.Text = "Sair";
            btn_exit.UseVisualStyleBackColor = true;
            btn_exit.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(388, 385);
            Controls.Add(btn_exit);
            Controls.Add(btn_clear);
            Controls.Add(btn_login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Controls.Add(pw);
            Controls.Add(username);
            Controls.Add(greeting);
            Name = "Form1";
            Text = "Login";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label greeting;
        private Label username;
        private Label pw;
        private TextBox txt_username;
        private TextBox txt_password;
        private Button btn_login;
        private Button btn_clear;
        private Button btn_exit;
    }
}