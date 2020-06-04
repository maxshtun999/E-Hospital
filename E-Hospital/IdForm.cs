using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E_Hospital
{
    public partial class IdForm : Form
    {
        public IdForm()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        



            SqlConnection sqlConnection = new SqlConnection(
                @"Server=tcp:ehospitalserver.database.windows.net,1433;
                Initial Catalog=E-HospitalDb;
                Persist Security Info=False;
                User ID=ehospitaladmin;
                Password=MaxAliSashaMikita4;
                MultipleActiveResultSets=False;
                Encrypt=True;
                TrustServerCertificate=False;
                Connection Timeout=30;");

            string query = "Select * from PatientInformation Where PatientId = '" + textBox1.Text.Trim() + "'";


            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count >= 1)
            {
                /* // редирект на меинформ при поиске, пока что не работает, потом допилю
                 this.Hide();
                 MainForm mainform = new MainForm();
                 mainform.Show();*/
                dataGridView1.DataSource = dataTable;
            }
            else if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Please insert patient's ID!", "Error");
            }
            else
            {
                DialogResult dialog = MessageBox.Show("Patient doesn't exist, do you want to create new?",
                 "Error", MessageBoxButtons.YesNo);
                if (dialog == DialogResult.Yes)
                {
                    this.Hide();
                    MainForm mainform = new MainForm();
                    mainform.Show();
                }

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to sign out for sure?",
         "Sign out", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                this.Hide();
                LoginForm login = new LoginForm();
                login.Show();
            }
 
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void IdForm_Load(object sender, EventArgs e)
        {

        }

        private void IdForm_FormClosing(object sender, FormClosingEventArgs e)
        {

            DialogResult dialog = MessageBox.Show("Do you want to close the application?",
                "Exit", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if(!Char.IsDigit(ch) && ch != 8 && ch !=46)
            {
                e.Handled = true;
            }
        }
    }
}
