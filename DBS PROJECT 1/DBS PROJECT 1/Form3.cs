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

    public partial class Form3 : Form
    {
        OracleConnection conn = new OracleConnection(@"DATA SOURCE=localhost:1521/orcl;DBA PRIVILEGE=SYSDBA;USER ID=SYS;Password=abhiram");
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.CAR' table. You can move, or remove it, as needed.
            this.cARTableAdapter.Fill(this.dataSet1.CAR);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn.Open();
            OracleCommand cmd = conn.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into car values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            MessageBox.Show("Inserted Successfully");

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.cARTableAdapter.Fill(this.dataSet1.CAR);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();
            this.Hide();

        }
    }
}
