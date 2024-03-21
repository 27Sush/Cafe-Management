using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cafemanage2.AllUserControls
{
    public partial class UC_Welcome : UserControl
    {
        public UC_Welcome()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        int num = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(num == 0)
            {
                labelBanner.Location = new Point(67, 430);
                labelBanner.ForeColor = Color.Orange;
                num++;
            }
            else if(num == 1)
            {
                labelBanner.Location = new Point(340, 430);
                labelBanner.ForeColor = Color.Green;
                num++; 
            }
            else if(num == 2)
            {
                labelBanner.Location = new Point(600, 430);
                labelBanner.ForeColor = Color.RoyalBlue;
                num = 0;
            }
        }

        private void UC_Welcome_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void labelBanner_Click(object sender, EventArgs e)
        {

        }
    }
}
