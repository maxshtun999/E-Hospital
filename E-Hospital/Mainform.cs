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
using System.Text.RegularExpressions;

namespace E_Hospital
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DisplayData();
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

        SqlCommand sqlCommand;
        SqlDataAdapter sqlDataAdapter;
        DataTable dataTable;
        int PatientId;

        //Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtFullname.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to save the patient!");
            }
            else if (txtHomeAddress.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to save the patient!");
            }
            else if (dtDateOfBirth == null)
            {
                MessageBox.Show("Please fill all the fields to save the patient!");
            }
            else if (txtEmail.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to save the patient!");
            }
            else if (txtTelephone.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to save the patient!");
            }
            else if (txtNotes.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to save the patient!");
            }
            else if (txtPostalCode.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to save the patient!");
            }
            else
            {
                string pattern = "^([0-9a-zA-Z]([-\\.\\w]*[0-9a-zA-Z])*@([0-9a-zA-Z][-\\w]*[0-9a-zA-Z]\\.)+[a-zA-Z]{2,9})$";
                if (Regex.IsMatch(txtEmail.Text, pattern))
                {
                    errorProvider1.Clear();
                    sqlConnection.Open();
                    sqlCommand = new SqlCommand
                    ("insert into PatientInformation values('" + txtFullname.Text + "','" + txtHomeAddress.Text + "','" + txtPostalCode.Text + "','" + dtDateOfBirth.Text + "','" + checkBoxSex.Text + "','" + txtEmail.Text + "', '" + txtTelephone.Text + "','" + txtNotes.Text + "'  )",
                    sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Your data has been saved in the database!");
                    sqlConnection.Close();
                    DisplayData();
                    Clear();
                }
                else
                {
                    errorProvider1.SetError(this.txtEmail, "Please provide correct email address");
                    return;
                }
            }

        }

        public void DisplayData()
        {
            sqlConnection.Open();
            sqlDataAdapter = new SqlDataAdapter("select * from PatientInformation", sqlConnection);
            dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            dataListOf.DataSource = dataTable;
            sqlConnection.Close();
        }

        public void Clear()
        {
            txtFullname.Text = "";
            txtHomeAddress.Text = "";
            txtPostalCode.Text = "";
            dtDateOfBirth.Text = "";
            checkBoxSex.Text = "";
            txtEmail.Text = "";
            txtTelephone.Text = "";
            txtNotes.Text = "";
        }

        //Update
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtFullname.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to update the patient!");
            }
            else if (txtHomeAddress.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to update the patient!");
            }
            else if (dtDateOfBirth == null)
            {
                MessageBox.Show("Please fill all the fields to update the patient!");
            }
            else if (txtEmail.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to update the patient!");
            }
            else if (txtTelephone.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to update the patient!");
            }
            else if (txtNotes.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to update the patient!");
            }
            else if (txtPostalCode.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to update the patient!");
            }
            else
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(
                    "update PatientInformation set PatientFullName='" + txtFullname.Text + "',Address='" +
                    txtHomeAddress.Text + "',PostalCode='" + txtPostalCode.Text + "',DateOfBirth='" + dtDateOfBirth.Text +
                    "',Gender='" + checkBoxSex.Text + "',Email='" + txtEmail.Text + "', Telephone='" + txtTelephone.Text +
                    "',Notes='" + txtNotes.Text + "'where PatientId='" + PatientId + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Data has been updated!");

                sqlConnection.Close();
                DisplayData();
            }
        }

        //Delete
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtFullname.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to Delete the patient!");
            }
            else if (txtHomeAddress.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to Delete the patient!");
            }
            else if (dtDateOfBirth == null)
            {
                MessageBox.Show("Please fill all the fields to Delete the patient!");
            }
            else if (txtEmail.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to Delete the patient!");
            }
            else if (txtTelephone.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to Delete the patient!");
            }
            else if (txtNotes.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to Delete the patient!");
            }
            else if (txtPostalCode.TextLength == 0)
            {
                MessageBox.Show("Please fill all the fields to Delete the patient!");
            }
            else
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand("delete from Patientinformation where PatientId='" + PatientId + "'", sqlConnection);
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Data has been deleted!");
                sqlConnection.Close();
                DisplayData();
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
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

        private void btnSearchAnotherUser_Click(object sender, EventArgs e)
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

        private void dataListOf_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            PatientId = Convert.ToInt32(dataListOf.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtFullname.Text = dataListOf.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtHomeAddress.Text = dataListOf.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtPostalCode.Text = dataListOf.Rows[e.RowIndex].Cells[3].Value.ToString();
            dtDateOfBirth.Text = dataListOf.Rows[e.RowIndex].Cells[4].Value.ToString();
            checkBoxSex.Text = dataListOf.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtEmail.Text = dataListOf.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtTelephone.Text = dataListOf.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtNotes.Text = dataListOf.Rows[e.RowIndex].Cells[8].Value.ToString();
        }

        private void txtTelephone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
