using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafemanage2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnGuest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Dashboard ds = new Dashboard("Guest");
            ds.Show();
            this.Hide();
        }
     
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if(txtUsername.Text == "" || txtPassword.Text == "")
            {
                MessageBox.Show("Username or Password cannot be empty.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    SqlConnection con = new SqlConnection("data source= ASUS\\SQLEXPRESS;Initial Catalog=restro;Integrated Security=True");
                    SqlCommand cmd = new SqlCommand("Select * from users where userid = @userid and password = @password", con);

                    // to hold query results
                    cmd.Parameters.AddWithValue("@userid", txtUsername.Text);
                    cmd.Parameters.AddWithValue("@password", txtPassword.Text);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    // 
                    da.Fill(dt);
                    if (dt.Rows.Count > 0)
                    {
                        MessageBox.Show("Login Successful.");

                        Dashboard ds = new Dashboard("Admin");
                        ds.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Username or Password is incorrect.");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("" + ex);
                }

            }


            /*
            if(txtUsername.Text=="Sushant" && txtPassword.Text == "Sushant@123")
            {
                Dashboard ds = new Dashboard("Admin");
                ds.Show();
                this.Hide();
            }
            */
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSignUp_Click(object sender, EventArgs e)
        {
            Form2 fn2 = new Form2();
            this.Hide();
            fn2.Show();
        }
    }
}
