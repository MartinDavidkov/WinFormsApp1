namespace WinFormsApp1
{
    partial class Form2
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
            username = new TextBox();
            usernamelabel = new Label();
            passwordLabel = new Label();
            password = new TextBox();
            login = new Button();
            SuspendLayout();
            // 
            // username
            // 
            username.Location = new Point(53, 91);
            username.Name = "username";
            username.Size = new Size(188, 23);
            username.TabIndex = 0;
            // 
            // usernamelabel
            // 
            usernamelabel.AutoSize = true;
            usernamelabel.Location = new Point(53, 73);
            usernamelabel.Name = "usernamelabel";
            usernamelabel.Size = new Size(60, 15);
            usernamelabel.TabIndex = 1;
            usernamelabel.Text = "Username";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(53, 205);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(57, 15);
            passwordLabel.TabIndex = 3;
            passwordLabel.Text = "Password";
            // 
            // password
            // 
            password.Location = new Point(53, 223);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(188, 23);
            password.TabIndex = 2;
            // 
            // login
            // 
            login.Location = new Point(82, 332);
            login.Name = "login";
            login.Size = new Size(113, 28);
            login.TabIndex = 4;
            login.Text = "Login";
            login.UseVisualStyleBackColor = true;
            login.Click += login_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 450);
            Controls.Add(login);
            Controls.Add(passwordLabel);
            Controls.Add(password);
            Controls.Add(usernamelabel);
            Controls.Add(username);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox username;
        private Label usernamelabel;
        private Label passwordLabel;
        private TextBox password;
        private Button login;
    }
}