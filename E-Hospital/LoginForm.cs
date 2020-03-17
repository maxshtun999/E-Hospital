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
        public new static LoginResult Show()
        {

            LoginForm frm = new LoginForm();
            frm.ShowDialog();

            LoginResult ret = frm.LogRes;

            frm.Dispose(true);
            return ret;
        }
        public LoginResult LogRes = LoginResult.NotStarted;

        public static PassResult Pass()
        {

            LoginForm frm = new LoginForm();
            frm.ShowDialog();

            PassResult ret = frm.PassRes;

            frm.Dispose(true);
            return ret;
        }
        public PassResult PassRes = PassResult.NotStarted;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (logbox.Text == "1" && passbox.Text == "2")
            {
                LogRes = LoginResult.OK;
            }
            //add synk to Db 
            else
            {
                LogRes = LoginResult.Failed;
                PassRes = PassResult.Failed;
                MessageBox.Show("Wrong Password or Login, Try again");
                Application.Restart();
            }
            this.Close();
        }

        private void logbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void passbox_TextChanged(object sender, EventArgs e)
        {

        }
    }
    public enum PassResult
    {
        OK,
        Failed,
        NotStarted
    }
    public enum LoginResult
    {
        OK,
        Failed,
        NotStarted
    }
}
