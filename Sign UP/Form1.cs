using System.Data;
using System.Data.SqlClient;

namespace Login_page
{
    public partial class Form1 : Form

    {
        public Form1()
        {
            InitializeComponent();
        }

        string contStg = @"Data Source=SAFKAT-LAPTOP\MSSQLSERVER01;Initial Catalog=Register;Integrated Security=True";

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {
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

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtlstnme_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtconPass_TextChanged(object sender, EventArgs e)
        {

        }
    }
}