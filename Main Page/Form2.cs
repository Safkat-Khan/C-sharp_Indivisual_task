using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Login_page
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        string contStg = @"";

        private void Form2_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtpass.UseSystemPasswordChar = false;
                txtconPass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
                txtconPass.UseSystemPasswordChar = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (txtusrnme.Text == "" || txtpass.Text == "" || txtconPass.Text == "")
            {
                MessageBox.Show("Please fill manatory fiels");
            }
            else if (txtpass.Text != txtconPass.Text)
            {
                MessageBox.Show("Password do not match");
            }
            else
            {
                using (SqlConnection sqlCon = new SqlConnection(contStg))
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("userAdd", sqlCon);
                    sqlCmd.CommandType = CommandType.StoredProcedure;
                    sqlCmd.Parameters.AddWithValue("@FirstName", txtfstnme.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@LastName", txtlstnme.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Email", txtemail.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@UserName", txtusrnme.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@Password", txtpass.Text.Trim());
                    sqlCmd.Parameters.AddWithValue("@ConfirmPassword", txtconPass.Text.Trim());
                    sqlCmd.ExecuteNonQuery();
                    MessageBox.Show("Registration is Successfull");

                    Clear();
                }
            }

        }
        void Clear()
        {
            txtfstnme.Text = txtlstnme.Text = txtemail.Text = txtusrnme.Text = txtpass.Text = txtconPass.Text = "";
        }

        private void txtpass_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            Form1 back = new Form1();
            back.Show();


        }
    }
}

