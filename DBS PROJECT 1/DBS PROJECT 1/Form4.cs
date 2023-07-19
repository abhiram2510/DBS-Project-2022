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
    public partial class Form4 : Form
    {
        OracleConnection conn = new OracleConnection("DATA SOURCE=localhost:1521/orcl;DBA PRIVILEGE=SYSDBA;USER ID=SYS;Password=abhiram");
        string choice;
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            choice = "NO";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            choice = "YES";
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (choice == "YES")
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandText = "insert into damage(REGNO,DAMAGEAMT,DAMAGEDESC) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Damage Added to the Bill Successfully!");
                Form7 f7 = new Form7();
                f7.Show();
                this.Hide();


            }
            else if(choice == "NO")
            {
                MessageBox.Show("No Damage included in the bill");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();
        }
    }
}
