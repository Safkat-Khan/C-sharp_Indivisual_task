namespace Login_page
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtfstnme = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            txtlstnme = new TextBox();
            txtemail = new TextBox();
            txtusrnme = new TextBox();
            txtpass = new TextBox();
            txtconPass = new TextBox();
            checkBox1 = new CheckBox();
            button1 = new Button();
            button2 = new Button();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(129, 91);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(390, 240);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(115, 380);
            label1.Name = "label1";
            label1.Size = new Size(94, 25);
            label1.TabIndex = 1;
            label1.Text = "Firstname";
            // 
            // txtfstnme
            // 
            txtfstnme.Location = new Point(258, 378);
            txtfstnme.Name = "txtfstnme";
            txtfstnme.Size = new Size(256, 27);
            txtfstnme.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(118, 440);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Lastname";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(153, 505);
            label3.Name = "label3";
            label3.Size = new Size(56, 25);
            label3.TabIndex = 1;
            label3.Text = "Email";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(113, 560);
            label4.Name = "label4";
            label4.RightToLeft = RightToLeft.No;
            label4.Size = new Size(96, 25);
            label4.TabIndex = 1;
            label4.Text = "Username";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(119, 622);
            label5.Name = "label5";
            label5.Size = new Size(90, 25);
            label5.TabIndex = 1;
            label5.Text = "Password";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(47, 686);
            label6.Name = "label6";
            label6.Size = new Size(162, 25);
            label6.TabIndex = 1;
            label6.Text = "Confirm Password";
            // 
            // txtlstnme
            // 
            txtlstnme.Location = new Point(258, 438);
            txtlstnme.Name = "txtlstnme";
            txtlstnme.Size = new Size(256, 27);
            txtlstnme.TabIndex = 8;
            // 
            // txtemail
            // 
            txtemail.Location = new Point(258, 503);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(256, 27);
            txtemail.TabIndex = 9;
            // 
            // txtusrnme
            // 
            txtusrnme.Location = new Point(258, 558);
            txtusrnme.Name = "txtusrnme";
            txtusrnme.Size = new Size(256, 27);
            txtusrnme.TabIndex = 10;
            // 
            // txtpass
            // 
            txtpass.Location = new Point(258, 620);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(256, 27);
            txtpass.TabIndex = 11;
            txtpass.UseSystemPasswordChar = true;
            txtpass.TextChanged += txtpass_TextChanged;
            // 
            // txtconPass
            // 
            txtconPass.Location = new Point(258, 684);
            txtconPass.Name = "txtconPass";
            txtconPass.Size = new Size(256, 27);
            txtconPass.TabIndex = 12;
            txtconPass.UseSystemPasswordChar = true;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(258, 740);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 13;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ControlDark;
            button1.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(135, 809);
            button1.Name = "button1";
            button1.Size = new Size(115, 49);
            button1.TabIndex = 15;
            button1.Text = "⬅ Back";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 102, 255);
            button2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(359, 809);
            button2.Name = "button2";
            button2.Size = new Size(142, 49);
            button2.TabIndex = 14;
            button2.Text = "🖋 Signup";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(257, 30);
            label7.Name = "label7";
            label7.Size = new Size(120, 41);
            label7.TabIndex = 11;
            label7.Text = "Signup";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Red;
            label8.Location = new Point(513, 557);
            label8.Name = "label8";
            label8.Size = new Size(15, 20);
            label8.TabIndex = 12;
            label8.Text = "*";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Red;
            label9.Location = new Point(513, 620);
            label9.Name = "label9";
            label9.Size = new Size(15, 20);
            label9.TabIndex = 12;
            label9.Text = "*";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Red;
            label10.Location = new Point(513, 684);
            label10.Name = "label10";
            label10.Size = new Size(15, 20);
            label10.TabIndex = 12;
            label10.Text = "*";
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(647, 933);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(checkBox1);
            Controls.Add(txtconPass);
            Controls.Add(txtpass);
            Controls.Add(txtusrnme);
            Controls.Add(txtemail);
            Controls.Add(txtlstnme);
            Controls.Add(txtfstnme);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form2";
            Text = "Registration";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtfstnme;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox txtlstnme;
        private TextBox txtemail;
        private TextBox txtusrnme;
        private TextBox txtpass;
        private TextBox txtconPass;
        private CheckBox checkBox1;
        private Button button1;
        private Button button2;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
    }
}