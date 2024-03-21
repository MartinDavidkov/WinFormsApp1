namespace WinFormsApp1
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
            email = new TextBox();
            label2 = new Label();
            username = new TextBox();
            password = new TextBox();
            button1 = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            length = new Label();
            capital = new Label();
            lowercase = new Label();
            number = new Label();
            bday = new DateTimePicker();
            gender = new ComboBox();
            phone = new TextBox();
            label5 = new Label();
            label6 = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // email
            // 
            email.Location = new Point(216, 42);
            email.Name = "email";
            email.PlaceholderText = "email";
            email.Size = new Size(100, 23);
            email.TabIndex = 0;
            email.Validating += email_Validating;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(216, 88);
            label2.Name = "label2";
            label2.Size = new Size(0, 15);
            label2.TabIndex = 3;
            // 
            // username
            // 
            username.Location = new Point(216, 97);
            username.Name = "username";
            username.PlaceholderText = "username";
            username.Size = new Size(100, 23);
            username.TabIndex = 2;
            username.Validating += username_Validating;
            // 
            // password
            // 
            password.Location = new Point(216, 146);
            password.Name = "password";
            password.PlaceholderText = "password";
            password.Size = new Size(100, 23);
            password.TabIndex = 4;
            password.TextChanged += password_TextChanged;
            password.Validating += password_Validating;
            // 
            // button1
            // 
            button1.Location = new Point(234, 375);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // length
            // 
            length.AutoSize = true;
            length.Location = new Point(179, 470);
            length.Name = "length";
            length.Size = new Size(183, 15);
            length.TabIndex = 7;
            length.Text = "Must contain at least 8 characters";
            length.Visible = false;
            // 
            // capital
            // 
            capital.AutoSize = true;
            capital.Location = new Point(174, 496);
            capital.Name = "capital";
            capital.Size = new Size(194, 15);
            capital.TabIndex = 8;
            capital.Text = "Must contain at least 1 capital letter";
            capital.Visible = false;
            // 
            // lowercase
            // 
            lowercase.AutoSize = true;
            lowercase.Location = new Point(164, 522);
            lowercase.Name = "lowercase";
            lowercase.Size = new Size(214, 15);
            lowercase.TabIndex = 9;
            lowercase.Text = "Must contain at least 1 lower case letter";
            lowercase.Visible = false;
            // 
            // number
            // 
            number.AutoSize = true;
            number.Location = new Point(184, 547);
            number.Name = "number";
            number.Size = new Size(171, 15);
            number.TabIndex = 10;
            number.Text = "Must contain at least 1 number";
            number.Visible = false;
            // 
            // bday
            // 
            bday.Location = new Point(184, 212);
            bday.Name = "bday";
            bday.Size = new Size(200, 23);
            bday.TabIndex = 11;
            bday.Validating += bday_Validating;
            // 
            // gender
            // 
            gender.AllowDrop = true;
            gender.DropDownStyle = ComboBoxStyle.DropDownList;
            gender.FormattingEnabled = true;
            gender.Items.AddRange(new object[] { "Female", "Male", "Not Specified" });
            gender.Location = new Point(202, 268);
            gender.Name = "gender";
            gender.Size = new Size(148, 23);
            gender.TabIndex = 12;
            // 
            // phone
            // 
            phone.Location = new Point(202, 320);
            phone.Name = "phone";
            phone.PlaceholderText = "phone number";
            phone.Size = new Size(148, 23);
            phone.TabIndex = 13;
            phone.Validating += phone_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(211, 250);
            label5.Name = "label5";
            label5.Size = new Size(45, 15);
            label5.TabIndex = 15;
            label5.Text = "Gender";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(211, 194);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 16;
            label6.Text = "Birth date";
            // 
            // button2
            // 
            button2.Location = new Point(180, 404);
            button2.Name = "button2";
            button2.Size = new Size(198, 23);
            button2.TabIndex = 17;
            button2.Text = "Already have an account?";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.night_photo;
            ClientSize = new Size(538, 615);
            Controls.Add(button2);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(phone);
            Controls.Add(gender);
            Controls.Add(bday);
            Controls.Add(number);
            Controls.Add(lowercase);
            Controls.Add(capital);
            Controls.Add(length);
            Controls.Add(button1);
            Controls.Add(password);
            Controls.Add(label2);
            Controls.Add(username);
            Controls.Add(email);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox email;
        private Label label2;
        private TextBox username;
        private TextBox password;
        private Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label length;
        private Label capital;
        private Label lowercase;
        private Label number;
        private DateTimePicker bday;
        private ComboBox gender;
        private TextBox phone;
        private Label label5;
        private Label label6;
        private Button button2;
    }
}