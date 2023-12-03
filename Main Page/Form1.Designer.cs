namespace Login_page
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            txtemail = new TextBox();
            button1 = new Button();
            txtpass = new TextBox();
            checkBox1 = new CheckBox();
            button2 = new Button();
            label2 = new Label();
            button3 = new Button();
            button5 = new Button();
            label3 = new Label();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, -3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(541, 765);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 20F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(652, 52);
            label1.Name = "label1";
            label1.Size = new Size(127, 46);
            label1.TabIndex = 1;
            label1.Text = "Sign In";
            // 
            // txtemail
            // 
            txtemail.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtemail.ForeColor = SystemColors.ControlDarkDark;
            txtemail.Location = new Point(643, 182);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(246, 30);
            txtemail.TabIndex = 2;
            txtemail.Text = "Enter Your Email";
            txtemail.Enter += textBox1_Enter;
            txtemail.Leave += textBox1_Leave;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(1007, -1);
            button1.Name = "button1";
            button1.Size = new Size(68, 29);
            button1.TabIndex = 1;
            button1.Text = "✕";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            button1.Enter += button1_Enter;
            // 
            // txtpass
            // 
            txtpass.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            txtpass.ForeColor = SystemColors.ControlDarkDark;
            txtpass.Location = new Point(643, 248);
            txtpass.Name = "txtpass";
            txtpass.Size = new Size(246, 30);
            txtpass.TabIndex = 3;
            txtpass.Text = "Enter Your Password";
            txtpass.TextChanged += txtpass_TextChanged;
            txtpass.Enter += textBox2_Enter;
            txtpass.Leave += textBox2_Leave;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(657, 301);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(132, 24);
            checkBox1.TabIndex = 4;
            checkBox1.Text = "Show Password";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(0, 64, 255);
            button2.FlatAppearance.BorderColor = Color.Blue;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = SystemColors.HighlightText;
            button2.Location = new Point(643, 349);
            button2.Name = "button2";
            button2.Size = new Size(246, 42);
            button2.TabIndex = 5;
            button2.Text = "Continue ➧";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(670, 422);
            label2.Name = "label2";
            label2.Size = new Size(203, 20);
            label2.TabIndex = 6;
            label2.Text = "or Connect with Social Media";
            // 
            // button3
            // 
            button3.BackColor = Color.RoyalBlue;
            button3.FlatAppearance.BorderColor = Color.Blue;
            button3.FlatAppearance.BorderSize = 0;
            button3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button3.ForeColor = SystemColors.HighlightText;
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.ImageAlign = ContentAlignment.TopLeft;
            button3.Location = new Point(643, 478);
            button3.Name = "button3";
            button3.Size = new Size(246, 45);
            button3.TabIndex = 6;
            button3.Text = "Facebook";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.White;
            button5.FlatAppearance.BorderColor = Color.FromArgb(64, 64, 64);
            button5.FlatAppearance.BorderSize = 0;
            button5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button5.ForeColor = SystemColors.WindowText;
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.TopLeft;
            button5.Location = new Point(643, 646);
            button5.Name = "button5";
            button5.Size = new Size(246, 46);
            button5.TabIndex = 8;
            button5.Text = "      Create an Account";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button4_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(760, 607);
            label3.Name = "label3";
            label3.Size = new Size(26, 20);
            label3.TabIndex = 9;
            label3.Text = "or,";
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(643, 543);
            button4.Name = "button4";
            button4.Size = new Size(246, 46);
            button4.TabIndex = 10;
            button4.Text = "Gmail";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1075, 750);
            Controls.Add(button4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(button5);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(txtpass);
            Controls.Add(txtemail);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Sign In";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private TextBox txtemail;
        private Button button1;
        private TextBox txtpass;
        private CheckBox checkBox1;
        private Button button2;
        private Label label2;
        private Button button3;
        private Button button5;
        private Label label3;
        private Button button4;
    }
}