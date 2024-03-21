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
    public partial class UC_UpdateItems : UserControl
    {

        function fn = new function();
        String query;
        public UC_UpdateItems()
        {
            InitializeComponent();
        }

        private void UC_UpdateItems_Load(object sender, EventArgs e)
        {
            loadData();
        }
        public void loadData()
        {
            query = "select * from items";
            DataSet ds = fn.getData(query);
            gunaDataGridView2.DataSource = ds.Tables[0];
        }

        private void txtUpdateSearchItem_TextChanged(object sender, EventArgs e)
        {
            query = "select * from items where name like '" + txtUpdateSearchItem.Text + "%'";
            DataSet ds = fn.getData(query);
            gunaDataGridView2.DataSource = ds.Tables[0];
        }

        int id;
        private void gunaDataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = int.Parse(gunaDataGridView2.Rows[e.RowIndex].Cells[0].Value.ToString());
            string category = gunaDataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            string name = gunaDataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            int price = int.Parse(gunaDataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString());

            txtUpdateCategory.Text = category;
            txtUpdateItemName.Text = name;
            txtUpdatePrice.Text = price.ToString();
        }

        private void btnUpdatebtn_Click(object sender, EventArgs e)
        {
            query = "update items set name = '"+txtUpdateItemName.Text+"', category = '"+txtUpdateCategory.Text+"' , price = "+txtUpdatePrice.Text+" where iid = "+id+" ";
            fn.setData(query);
            loadData();

            // To clear the textboxes
            txtUpdateItemName.Clear();
            txtUpdatePrice.Clear() ;
            txtUpdateCategory.Clear();
        }
    }
}
