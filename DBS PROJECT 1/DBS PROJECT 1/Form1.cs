using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Types;
using Oracle.ManagedDataAccess.Client;

namespace DBS_PROJECT_1
{
    public partial class Form1 : Form
    {
        OracleConnection conn = new OracleConnection(@"DATA SOURCE=localhost:1521/orcl;DBA PRIVILEGE=SYSDBA;USER ID=SYS;Password=abhiram");
        public Form1()
        {
            InitializeComponent();
        }

        public void ConnectDB()
        {
            conn = new OracleConnection(@"DATA SOURCE=localhost:1521/orcl;DBA PRIVILEGE=SYSDBA;USER ID=SYS;Password=abhiram");
            try
            {
                conn.Open();
                MessageBox.Show("Connected");
            }
            catch (Exception e)
            {
                MessageBox.Show("NOT Connected");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username, password;
            OracleCommand cmd = conn.CreateCommand();
            username = textBox1.Text;
            password = textBox2.Text;

            try
            {
                string q = "select * from login where username= '" + textBox1.Text + "' and password ='" + textBox2.Text + "' ";
                OracleDataAdapter oc = new OracleDataAdapter(q, conn);
                DataTable dtable = new DataTable();
                oc.Fill(dtable);
                if (dtable.Rows.Count > 0)
                {
                    username = textBox1.Text;
                    password = textBox2.Text;

                    if(username=="admin" && password == "admin")
                    {
                        Form2 f2 = new Form2();
                        f2.Show();
                        this.Hide();

                    }

                    else if(username == "customer" && password == "customer")
                    {
                        Form9 f9 = new Form9();
                        f9.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Please Enter Again");
                        textBox1.Clear();
                        textBox2.Clear();

                        textBox1.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Login Details", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBox1.Clear();
                    textBox2.Clear();

                    textBox1.Focus();
                }

            }

            catch
            {
                MessageBox.Show("Error");
            }
            finally
            {
                conn.Close();
            }

            /*if (username == "admin" && password == "admin")
            {
                MessageBox.Show("Admin login successful!");
                username = textBox1.Text;
                password = textBox2.Text;

                Form2 f2 = new Form2();
                f2.Show();
                this.Hide();


            }
            else if (username == "customer" && password == "customer")
            {
                MessageBox.Show("customer login successful!");
                username = textBox1.Text;
                password = textBox2.Text;
            }
            else
            {
                MessageBox.Show("Invalid Login Details", "Errors", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Clear();
                textBox2.Clear();

                textBox1.Focus();
            }*/
        
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult res;
            res = MessageBox.Show("Do you want to exit", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                this.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();

            textBox1.Focus();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked== true)
            {
                textBox2.UseSystemPasswordChar = false;

            }
            else
            {
                textBox2.UseSystemPasswordChar = true;

            }
        }
    }
}
