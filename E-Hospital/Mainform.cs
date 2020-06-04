using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace E_Hospital
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

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


        private void button2_Click(object sender, EventArgs e)
        {

            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to save the patient!");
            }
            else if (textBox2.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to save the patient!");
            }
            else if (checkedListBox1 == null)
            {
                MessageBox.Show("Please fill all the fields to save the patient!");
            }
            else if (textBox3.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to save the patient!");
            }
            else if(textBox4.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to save the patient!");
            }
            else if (textBox5.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to save the patient!");
            }
            else
            {
                sqlConnection.Open();
                String query = "INSERT INTO PatientInformation (PatientFullName,Address,DateofBirth,Gender,Email,Telephone,Notes) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + dateTimePicker1.Text + "','" + checkedListBox1.Text + "','" + textBox4.Text + "','" + textBox3.Text + "','" + textBox5.Text + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                SDA.SelectCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Patient saved successfully!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Please enter name to update patient's info!");
            }
            else if (textBox3.TextLength == 0)
            {
                MessageBox.Show("Please enter phone number to  to update patient's info!!");
            }
            else if (textBox5.TextLength == 0)
            {
                MessageBox.Show("Please enter the notes to update them!");
            }
            else
            {
                sqlConnection.Open();
                string query = "UPDATE PatientInformation SET PatientFullName = '" + textBox1.Text + "',Address = '" + textBox2.Text + "', DateofBirth = '" + dateTimePicker1.Text + "', Gender = '" + checkedListBox1.Text + "', Email = '" + textBox4.Text + "',Telephone = '" + textBox3.Text + "', Notes = '" + textBox5.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                SDA.SelectCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Patient data updated successfully!");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            String query = "SELECT PatientFullName, Address, DateofBirth, Gender, Email, Telephone FROM PatientInformation";
            string query1 = "SELECT Notes FROM PatientInformation";
            SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
            SqlDataAdapter SDA1 = new SqlDataAdapter(query1, sqlConnection);
            DataTable dt = new DataTable();
            DataTable dt1 = new DataTable();
            SDA.Fill(dt);
            SDA1.Fill(dt1);
            dataGridView1.DataSource = dt;
            dataGridView2.DataSource = dt1;
            sqlConnection.Close();
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            checkedListBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox5.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();

        }

        private void dataGridView2_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            dateTimePicker1.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            checkedListBox1.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            textBox4.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            textBox3.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            textBox5.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox1.TextLength == 0)
            {
                MessageBox.Show("Please Enter name to Delete!");
            }
            else
            {
                sqlConnection.Open();
                String query = "DELETE FROM PatientInformation where PatientFullName = '" + textBox1.Text + "'";
                SqlDataAdapter SDA = new SqlDataAdapter(query, sqlConnection);
                SDA.SelectCommand.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Medical card deleted!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            InitializeComponent();

        }

        private void button8_Click(object sender, EventArgs e)
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

        private void button7_Click(object sender, EventArgs e)
        {
            IdForm idform = new IdForm();
            this.Hide();
            idform.Show();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
