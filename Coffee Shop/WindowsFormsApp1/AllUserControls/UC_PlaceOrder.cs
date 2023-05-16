using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace WindowsFormsApp1.AllUserControls
{
    
    public partial class UC_PlaceOrder : UserControl
    {
        function fn = new function();
        String query;

        public UC_PlaceOrder()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            String category = comboCategory.Text;
            query = "select name from items where category ='" + category + "' ";
            DataSet ds = fn.getData(query);

            
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++) 
            {
                listBox1.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }
    }
}
