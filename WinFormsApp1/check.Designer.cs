namespace WinFormsApp1
{
    partial class check
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
            dataGridView1 = new DataGridView();
            button1 = new Button();
            button2 = new Button();
            reserve = new Button();
            comboBox1 = new ComboBox();
            comboBox2 = new ComboBox();
            comboBox3 = new ComboBox();
            comboBox4 = new ComboBox();
            seeReservations = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 44);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(528, 241);
            dataGridView1.TabIndex = 0;
            // 
            // button1
            // 
            button1.Location = new Point(12, 291);
            button1.Name = "button1";
            button1.Size = new Size(86, 28);
            button1.TabIndex = 1;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(113, 291);
            button2.Name = "button2";
            button2.Size = new Size(86, 28);
            button2.TabIndex = 2;
            button2.Text = "Clear Filters";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // reserve
            // 
            reserve.Location = new Point(455, 291);
            reserve.Name = "reserve";
            reserve.Size = new Size(86, 28);
            reserve.TabIndex = 3;
            reserve.Text = "Reserve";
            reserve.UseVisualStyleBackColor = true;
            reserve.Click += reserve_Click;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "available", "not available" });
            comboBox1.Location = new Point(12, 15);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(101, 23);
            comboBox1.TabIndex = 4;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "outside", "inside" });
            comboBox2.Location = new Point(149, 15);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(102, 23);
            comboBox2.TabIndex = 5;
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Items.AddRange(new object[] { "over 4", "under 4" });
            comboBox3.Location = new Point(300, 15);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(94, 23);
            comboBox3.TabIndex = 6;
            // 
            // comboBox4
            // 
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "yes", "no" });
            comboBox4.Location = new Point(453, 15);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(87, 23);
            comboBox4.TabIndex = 7;
            // 
            // seeReservations
            // 
            seeReservations.Location = new Point(322, 291);
            seeReservations.Name = "seeReservations";
            seeReservations.Size = new Size(114, 28);
            seeReservations.TabIndex = 8;
            seeReservations.Text = "See Reservations";
            seeReservations.UseVisualStyleBackColor = true;
            seeReservations.Click += seeReservations_Click;
            // 
            // check
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(576, 359);
            Controls.Add(seeReservations);
            Controls.Add(comboBox4);
            Controls.Add(comboBox3);
            Controls.Add(comboBox2);
            Controls.Add(comboBox1);
            Controls.Add(reserve);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "check";
            Text = "check";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button reserve;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox3;
        private ComboBox comboBox4;
        private Button seeReservations;
    }
}