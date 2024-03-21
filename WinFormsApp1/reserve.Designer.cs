namespace WinFormsApp1
{
    partial class reserve
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
            name = new TextBox();
            phone = new TextBox();
            tableID = new TextBox();
            reserve1 = new Button();
            SuspendLayout();
            // 
            // name
            // 
            name.Location = new Point(18, 19);
            name.Name = "name";
            name.PlaceholderText = "Name";
            name.Size = new Size(163, 23);
            name.TabIndex = 0;
            // 
            // phone
            // 
            phone.Location = new Point(18, 62);
            phone.Name = "phone";
            phone.PlaceholderText = "Phone Number";
            phone.Size = new Size(163, 23);
            phone.TabIndex = 1;
            // 
            // tableID
            // 
            tableID.Location = new Point(18, 104);
            tableID.Name = "tableID";
            tableID.PlaceholderText = "TableID";
            tableID.Size = new Size(163, 23);
            tableID.TabIndex = 2;
            // 
            // reserve1
            // 
            reserve1.Location = new Point(57, 149);
            reserve1.Name = "reserve1";
            reserve1.Size = new Size(75, 23);
            reserve1.TabIndex = 3;
            reserve1.Text = "Reserve";
            reserve1.UseVisualStyleBackColor = true;
            reserve1.Click += reserve1_Click;
            // 
            // reserve
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(200, 196);
            Controls.Add(reserve1);
            Controls.Add(tableID);
            Controls.Add(phone);
            Controls.Add(name);
            Name = "reserve";
            Text = "reserve";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox name;
        private TextBox phone;
        private TextBox tableID;
        private Button reserve1;
    }
}