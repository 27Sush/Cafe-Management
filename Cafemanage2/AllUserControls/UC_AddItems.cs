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
    public partial class UC_AddItems : UserControl
    {
        function fn = new function();
        string query;
        public UC_AddItems()
        {
            InitializeComponent();
        }
        
        private void UC_AddItems_Leave(object sender, EventArgs e)
        {
            clearAll();
          //clear
        }

        /*  GunaButton in UC_AddItems.cs
        private void btnAddItem_Click(object sender, EventArgs e)
        {
            query = "insert into items(name,category,price) values('" + txtItemName.Text + "','" + txtCategory.Text + "'," + txtPrice.Text + ")";
            fn.setData(query);
            clearAll();
        } */

        private void btnAddItem_Click_1(object sender, EventArgs e)
        {
            query = "insert into items(name,category,price) values('" + txtItemName.Text + "','" + txtCategory.Text + "'," + txtPrice.Text + ")";
            fn.setData(query);
            clearAll();
        }
        public void clearAll()// To clear textboxes after insertion
        {
            txtCategory.SelectedIndex = -1;
            txtItemName.Clear();
            txtPrice.Clear();
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
