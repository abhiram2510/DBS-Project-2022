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
    public partial class Form8 : Form
    {
        string choice;
        OracleConnection conn = new OracleConnection(@"DATA SOURCE=localhost:1521/orcl;DBA PRIVILEGE=SYSDBA;USER ID=SYS;Password=abhiram");
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = null;

            // TODO: This line of code loads data into the 'dataSet3.CAR' table. You can move, or remove it, as needed.
            this.cARTableAdapter.Fill(this.dataSet3.CAR);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (choice == "Premium")
            {
                string query = "SELECT * FROM car WHERE Type = 'Prem' and availability = 'yes'";
                OracleCommand command = new OracleCommand(query, conn);


                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                OracleDataAdapter adp = new OracleDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(dataset);

                if (dataset.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Premium cars not available.");
                    return;
                }

                dataGridView1.DataSource = dataset.Tables[0];
            }
            else if(choice == "Normal")
            {
                string query = "SELECT * FROM car WHERE Type = 'Normal' and availability = 'yes'";
                OracleCommand command = new OracleCommand(query, conn);


                OracleDataAdapter adapter = new OracleDataAdapter(command);
                DataSet dataset = new DataSet();
                adapter.Fill(dataset);

                OracleDataAdapter adp = new OracleDataAdapter(command);
                DataSet ds = new DataSet();
                adapter.Fill(dataset);

                if (dataset.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("Premium cars not available.");
                    return;
                }

                dataGridView1.DataSource = dataset.Tables[0];

            }
            else
            {
                MessageBox.Show("Please select an option");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.Show();
            this.Hide();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            choice = "Premium";

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            choice = "Normal";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Last Step!");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
