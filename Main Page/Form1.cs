using Microsoft.VisualBasic.ApplicationServices;
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
        SqlConnection conn = new SqlConnection(@"Data Source=SAFKAT-LAPTOP\MSSQLSERVER01;Initial Catalog=Register;Integrated Security=True");
        private void button1_Enter(object sender, EventArgs e)
        {

        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (txtemail.Text == "Enter Your Email")
            {
                txtemail.Text = "";

                txtemail.ForeColor = Color.Black;
            }
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (txtemail.Text == "")
            {
                txtemail.Text = "Enter Your Email";

                txtemail.ForeColor = Color.Gray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (txtpass.Text == "Enter Your Password")
            {
                txtpass.Text = "";

                txtpass.ForeColor = Color.Black;
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (txtpass.Text == "")
            {
                txtpass.Text = "Enter Your Password";

                txtpass.ForeColor = Color.Gray;
                txtpass.UseSystemPasswordChar = false;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txtpass.UseSystemPasswordChar = false;
            }
            else
            {
                txtpass.UseSystemPasswordChar = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Owner = this;
            f2.Show();

            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /* string email, password;
             email = txtemail.Text;
             password = txtpass.Text;

             try
             {
                 string querry = "SELECT * FROM Register  WHERE email ='" + txtemail.Text + "' AND password ='" + txtpass.Text + "'";
                 SqlDataAdapter adapter = new SqlDataAdapter(querry, conn);

                 DataTable dt = new DataTable();
                 adapter.Fill(dt);

                 if (dt.Rows.Count > 0)
                 {
                     email = txtemail.Text;
                     password = txtpass.Text;
                 }

     }
             catch
             {
                 MessageBox.Show("Invalid Email and Password");
             }
             finally
             {
                 conn.Close();
             }*/
            Form3 f3 = new Form3();
            f3.Owner = this;
            f3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to close the form?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Feature Will be added Soon");
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Feature Will be added Soon");
        }
    }
}