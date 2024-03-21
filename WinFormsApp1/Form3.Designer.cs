namespace WinFormsApp1
{
    partial class Form3
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
            welcome = new TextBox();
            pictureBox1 = new PictureBox();
            uploadBtn = new Button();
            email = new TextBox();
            phone = new TextBox();
            enter = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // welcome
            // 
            welcome.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            welcome.Location = new Point(12, 223);
            welcome.Name = "welcome";
            welcome.Size = new Size(530, 39);
            welcome.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.userphoto;
            pictureBox1.Image = Properties.Resources.userphoto;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(182, 165);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // uploadBtn
            // 
            uploadBtn.Location = new Point(68, 183);
            uploadBtn.Name = "uploadBtn";
            uploadBtn.Size = new Size(75, 23);
            uploadBtn.TabIndex = 2;
            uploadBtn.Text = "upload";
            uploadBtn.UseVisualStyleBackColor = true;
            uploadBtn.Click += uploadBtn_Click;
            // 
            // email
            // 
            email.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            email.Location = new Point(12, 284);
            email.Name = "email";
            email.Size = new Size(530, 39);
            email.TabIndex = 3;
            // 
            // phone
            // 
            phone.Font = new Font("Times New Roman", 20.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            phone.Location = new Point(12, 344);
            phone.Name = "phone";
            phone.Size = new Size(530, 39);
            phone.TabIndex = 4;
            // 
            // enter
            // 
            enter.Location = new Point(334, 79);
            enter.Name = "enter";
            enter.Size = new Size(112, 57);
            enter.TabIndex = 5;
            enter.Text = "Enter the system";
            enter.UseVisualStyleBackColor = true;
            enter.Click += enter_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.night_photo;
            ClientSize = new Size(554, 450);
            Controls.Add(enter);
            Controls.Add(phone);
            Controls.Add(email);
            Controls.Add(uploadBtn);
            Controls.Add(pictureBox1);
            Controls.Add(welcome);
            Name = "Form3";
            Text = "Form3";
            Load += Form3_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox welcome;
        private PictureBox pictureBox1;
        private Button uploadBtn;
        private TextBox email;
        private TextBox phone;
        private Button enter;
    }
}