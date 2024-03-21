using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafemanage2
{
    public partial class Form2 : Form
    {
        function fn = new function();
        String query;
        public Form2()
        {
            InitializeComponent();
        }

        private void btnSignUp2_Click(object sender, EventArgs e)
        {

            query = "insert into users(userid, password, confirmpass) values ('" + txtSignUpUsername.Text + "', '" + txtSignUpPassword.Text + "', '" + txtSignUpConfirmPass.Text + "')";
            try
            {
                if (txtSignUpPassword.Text == txtSignUpConfirmPass.Text)
                {
                    fn.setData(query);
                }
                else
                {
                    MessageBox.Show("Password doesn't match.", "Important Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }

            loadForm1();
            /*
            Form1 fn = new Form1();
            this.Hide();
            fn.Show();
            */
        }
        public void loadForm1()
        {
            Form1 fn = new Form1();
            this.Hide();
            fn.Show();
        }

        private void txtSignUpUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSignUpPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
