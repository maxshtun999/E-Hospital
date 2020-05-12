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
                MainForm objMainForm = new MainForm();
                this.Hide();
                objMainForm.Show();
            }
            else
            {
                MessageBox.Show("Check your Username and Password!");
            }
        }
    }
}
