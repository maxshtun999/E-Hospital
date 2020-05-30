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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            //Connection with Azure Server to check login identity Aliagha
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
            string query = "Select * from Login Where Username = '" + txtUsername.Text.Trim() + "' and Password ='" +
                           txtPassword.Text.Trim() + "'";

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, sqlConnection);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                IdForm idform = new IdForm();
                this.Hide();
                idform.Show();
                
            }
            else if (txtUsername.TextLength == 0 || txtPassword.TextLength == 0)
            {
                MessageBox.Show("Please enter username and password!", "Error");
            }
            else
            {
                MessageBox.Show("Wrong username or password!", "Error");
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Do you want to close the application?",
                "Exit", MessageBoxButtons.YesNo);
            if(dialog == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else if (dialog == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
