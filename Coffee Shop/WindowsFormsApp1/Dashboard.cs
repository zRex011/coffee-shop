using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }
        public Dashboard(String user)
        {
            InitializeComponent();

            if(user == "Guest" ) 
            {
             btnAddItems.Hide();
             btnUpdateItems.Hide();
             btnRemoveItems.Hide();
            }
            else if (user =="Admin")
            {
                btnAddItems.Show();
                btnUpdateItems.Show();
                btnRemoveItems.Show();

            }
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = false;
            uC_PlaceOrder1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            uC_AddItems1.Visible = true;    
            uC_AddItems1.BringToFront(); 
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void uC_AddItems1_Load(object sender, EventArgs e)
        {

        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void btnPlaceOrder_Click(object sender, EventArgs e)
        {
            uC_PlaceOrder1.Visible = true;
            uC_PlaceOrder1.BringToFront();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
