using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.AllUserControls
{
    public partial class UC_AddItems : UserControl
    {
        function fn = new function();
        String query;

        public UC_AddItems()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
           query = "insert into items (name, category,price) values ('"+txtItem.Text+ "','"+txtCategory.Text+ "','"+txtPrice.Text+"')";
            fn.setData(query);
            clearAll();
        }
        public void clearAll()
        {
            txtCategory.SelectedIndex = -1;
            txtItem.Clear();
            txtPrice.Clear();

        }

        private void UC_AddItems_Leave(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
