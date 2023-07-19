using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBS_PROJECT_1
{
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }
        
        bool checkdate()
        {
            DateTime fromdate = Convert.ToDateTime(dateTimePicker1.Text);
            DateTime todate = Convert.ToDateTime(dateTimePicker2.Text);
            if (fromdate >= todate)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (checkdate())
            {
                MessageBox.Show("OK!");
                Form8 f8 = new Form8();
                f8.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Should be rented for a minimum of 1 day!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Call number: +91 8023810939 OR Email us at golocalrentals@gmail.com");
        }
    }
}
