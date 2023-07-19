using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace DBS_PROJECT_1
{
    public partial class Form5 : Form
    {
        string pref;
        OracleConnection conn = new OracleConnection(@"DATA SOURCE=localhost:1521/orcl;DBA PRIVILEGE=SYSDBA;USER ID=SYS;Password=abhiram");
        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet2.CAR' table. You can move, or remove it, as needed.
            this.cARTableAdapter.Fill(this.dataSet2.CAR);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (pref == "Yes")
            {
                
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "insert into customer(CUSTNAME,EMAIL,PHONENUMBER,ADDRESS) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                string phone;
                phone = textBox3.Text;
                if (phone.Length != 10)
                {
                    MessageBox.Show("Phone number should be 10 digits!");
                }
                else
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Almost there :)");
                    Form6 f6 = new Form6();
                    f6.Show();
                    this.Hide();
                }
                conn.Close();
            }
            else
            {
                MessageBox.Show("You cannot rent a vehicle");
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            pref = "Yes";
            
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            pref = "No";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();


        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("Call number: +91 8023810939 OR Email us at golocalrentals@gmail.com");
        }
    }
}
