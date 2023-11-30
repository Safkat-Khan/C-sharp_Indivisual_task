namespace DashBoard_From
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox2 = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            label1 = new Label();
            pictureBox3 = new PictureBox();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label6 = new Label();
            textBox2 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            dataGridView1 = new DataGridView();
            button9 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(102, 153, 255);
            pictureBox2.Location = new Point(-1, -5);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1487, 95);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.FlatAppearance.BorderSize = 0;
            button1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1434, -3);
            button1.Name = "button1";
            button1.Size = new Size(42, 42);
            button1.TabIndex = 2;
            button1.Text = "X";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(76, 153, 230);
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.HighlightText;
            button2.Location = new Point(12, 219);
            button2.Name = "button2";
            button2.Size = new Size(248, 64);
            button2.TabIndex = 3;
            button2.Text = "🏠 Home";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Location = new Point(12, 310);
            button3.Name = "button3";
            button3.Size = new Size(248, 64);
            button3.TabIndex = 4;
            button3.Text = "Post Job";
            button3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(102, 153, 255);
            label1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(363, 36);
            label1.Name = "label1";
            label1.Size = new Size(90, 23);
            label1.TabIndex = 5;
            label1.Text = "UserName";
            label1.Click += label1_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(102, 153, 255);
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(29, 12);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(196, 183);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // button4
            // 
            button4.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Location = new Point(12, 416);
            button4.Name = "button4";
            button4.Size = new Size(248, 64);
            button4.TabIndex = 7;
            button4.Text = "Edit Job";
            button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            button5.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button5.Location = new Point(12, 524);
            button5.Name = "button5";
            button5.Size = new Size(248, 64);
            button5.TabIndex = 8;
            button5.Text = "Delete Job";
            button5.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Location = new Point(12, 620);
            button6.Name = "button6";
            button6.Size = new Size(248, 64);
            button6.TabIndex = 9;
            button6.Text = "Confirm Job";
            button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            button7.BackColor = Color.FromArgb(230, 115, 76);
            button7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Location = new Point(12, 713);
            button7.Name = "button7";
            button7.Size = new Size(248, 64);
            button7.TabIndex = 10;
            button7.Text = "Payment";
            button7.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(102, 153, 255);
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(263, 34);
            label3.Name = "label3";
            label3.Size = new Size(89, 25);
            label3.TabIndex = 12;
            label3.Text = "Welcome";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(102, 153, 255);
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(1247, 36);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 13;
            label2.Text = "Change Password";
            label2.Click += label2_Click_2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(480, 280);
            label4.Name = "label4";
            label4.Size = new Size(0, 20);
            label4.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(396, 138);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 15;
            label5.Text = "Tittle";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(396, 181);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(207, 27);
            textBox1.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(891, 138);
            label6.Name = "label6";
            label6.Size = new Size(108, 25);
            label6.TabIndex = 17;
            label6.Text = "Description";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(891, 168);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(254, 82);
            textBox2.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(396, 294);
            label7.Name = "label7";
            label7.Size = new Size(73, 25);
            label7.TabIndex = 19;
            label7.Text = "Budget";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(396, 344);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(207, 27);
            textBox3.TabIndex = 20;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(891, 294);
            label8.Name = "label8";
            label8.Size = new Size(110, 25);
            label8.TabIndex = 21;
            label8.Text = "Hourly Rate";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(891, 347);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(207, 27);
            textBox4.TabIndex = 20;
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.HighlightText;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(396, 407);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(938, 304);
            dataGridView1.TabIndex = 22;
            // 
            // button9
            // 
            button9.Location = new Point(1240, 364);
            button9.Name = "button9";
            button9.Size = new Size(94, 37);
            button9.TabIndex = 24;
            button9.Text = "⟳ Refresh";
            button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            button8.BackColor = Color.OrangeRed;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            button8.ForeColor = SystemColors.HighlightText;
            button8.Location = new Point(800, 732);
            button8.Name = "button8";
            button8.Size = new Size(120, 45);
            button8.TabIndex = 25;
            button8.Text = "Log Out";
            button8.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1477, 807);
            Controls.Add(button8);
            Controls.Add(button9);
            Controls.Add(dataGridView1);
            Controls.Add(label8);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(label7);
            Controls.Add(textBox2);
            Controls.Add(label6);
            Controls.Add(textBox1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label3);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(pictureBox3);
            Controls.Add(label1);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pictureBox2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Admin Dashboard";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox pictureBox2;
        private Button button1;
        private Button button2;
        private Button button3;
        private Label label1;
        private PictureBox pictureBox3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Label label3;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox textBox1;
        private Label label6;
        private TextBox textBox2;
        private Label label7;
        private TextBox textBox3;
        private Label label8;
        private TextBox textBox4;
        private DataGridView dataGridView1;
        private Button button9;
        private Button button8;
    }
}