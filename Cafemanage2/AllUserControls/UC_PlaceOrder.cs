using DGVPrinterHelper;
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
    public partial class UC_PlaceOrder : UserControl
    {
        function fn = new function();
        String query;

        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

        private void gunaComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String category = comboCategory.Text;
            query = "select name from items where category = '" + category + "'";

            showItemsList(query);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

            String category = comboCategory.Text;
            query = "select name from items where category = '" + category + "' and name like '"+txtSearch.Text+"%' ";
            
            showItemsList(query);
        }

        private void showItemsList(String query)
        {
            listBox1.Items.Clear();

            DataSet ds = fn.getData(query);
            for(int i=0; i< ds.Tables[0].Rows.Count; i++)
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //numericUpDown1.ResetText();
            numericUpDown1.Value = 0;
            txtPlaceTotal.Clear();

            String text = listBox1.GetItemText(listBox1.SelectedItem);
            txtItemName.Text = text;

            query = "select price from items where name = '"+text+"'";
            DataSet ds = fn.getData(query);
            try
            {
                txtPlacePrice.Text = ds.Tables[0].Rows[0][0].ToString();
            }
            catch { }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Int64 quan = Int64.Parse(numericUpDown1.Value.ToString());
            Int64 price = Int64.Parse(txtPlacePrice.Text);

            txtPlaceTotal.Text = (quan * price).ToString();
        }

        private void txtPlacePrice_TextChanged(object sender, EventArgs e)
        {

        }

        protected int n, total = 0;

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                gunaDataGridView1.Rows.RemoveAt(this.gunaDataGridView1.SelectedRows[0].Index);
            }
            catch { }

            total = total - amount;
            labelGrandTotalAmount.Text = "Rs. " + total;
        }

        int amount;
        private void gunaDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                amount = int.Parse(gunaDataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString());
            }
            catch { }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DGVPrinter printer = new DGVPrinter();

            printer.Title = "Pizza Burst\n Customer Bill\n\n";
            printer.TitleColor = Color.Red;
            printer.SubTitleColor = Color.Green;    
            printer.SubTitle = string.Format("Date; {0}\n\n", DateTime.Now.Date);
            printer.SubTitleFormatFlags = StringFormatFlags.LineLimit | StringFormatFlags.NoClip;

            printer.PageNumbers = true;
            printer.PageNumberInHeader = false;
            printer.PorportionalColumns = true;
            printer.HeaderCellAlignment = StringAlignment.Near;
            printer.Footer = "Total Payable Amount: " + labelGrandTotalAmount.Text;

            printer.FooterSpacing = 15;
            printer.PrintDataGridView(gunaDataGridView1);

            total = 0;
            gunaDataGridView1.Rows.Clear();
            labelGrandTotalAmount.Text = "Rs. " + total;
        }

        private void btnAddtoCart_Click(object sender, EventArgs e)
        {

            if (txtPlaceTotal.Text != "0" && txtPlaceTotal.Text != "")
            {
                n = gunaDataGridView1.Rows.Add();
                gunaDataGridView1.Rows[n].Cells[0].Value = txtItemName.Text;
                gunaDataGridView1.Rows[n].Cells[1].Value = txtPlacePrice.Text;
                gunaDataGridView1.Rows[n].Cells[2].Value = numericUpDown1.Value;
                gunaDataGridView1.Rows[n].Cells[3].Value = txtPlaceTotal.Text;

                total = total + int.Parse(txtPlaceTotal.Text);
                labelGrandTotalAmount.Text = "Rs. " + total;
            }
            else
            {
                MessageBox.Show("Minimum Quantity needs to be 1", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }


        }
    }
}
