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
    
    public partial class Form10 : Form
        
    {
        OracleConnection conn = new OracleConnection(@"DATA SOURCE=localhost:1521/orcl;DBA PRIVILEGE=SYSDBA;USER ID=SYS;Password=abhiram");
        string feedback;
        public Form10()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            feedback = "sad";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form9 f9 = new Form9();
            f9.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string phoneno = textBox2.Text;
            if(phoneno.Length != 10)
            {
                MessageBox.Show("Phone number is not valid!");
            }
            else
            {
                conn.Open();
                OracleCommand cmd = conn.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "insert into feedback values('" + textBox1.Text + "','" + textBox2.Text + "','" + feedback + "','" + richTextBox1.Text + "')";
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show("Thank you for your feedback");


            }
            

        }

        private void Form10_Load(object sender, EventArgs e)
        {

        }
        

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            feedback = "Very Happy";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            feedback = "angry";

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            feedback = "not satisfied";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            feedback = "Satisfied";
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
