using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace imdb
{
    public partial class RegisterForm : Form
    {

        string ordb = "Data source=orcl;User Id=hr;Password=hh;";
        OracleConnection conn;
        private Thread thread;

        public RegisterForm()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            this.Close();
            thread = new Thread(openLoginForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();

        }



        private void openLoginForm(object obj)
        {
            Application.Run(new LoginForm());
        }


        private void btn_register_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            cmd.CommandText = "insert into Users values (:name,:phoneNumber,:password)";
            //Check The register Data
            if (String.IsNullOrEmpty(tb_name.Text) || String.IsNullOrEmpty(tb_phone_number.Text) || String.IsNullOrEmpty(tb_password.Text))
            {
                MessageBox.Show("Text is empty");
            }
            else
            {
                //Check the Password and confirm password is the same
                if (tb_password.Text.ToString() == tb_confirm_password.Text.ToString())
                {
                    cmd.Parameters.Add("name", tb_name.Text);
                    cmd.Parameters.Add("phoneNumber", tb_phone_number.Text);
                    cmd.Parameters.Add("password", tb_password.Text);
                }
                else
                {
                    MessageBox.Show("Password Not Matching");
                }
                int r = cmd.ExecuteNonQuery();
                if (r != -1)
                {
                    MessageBox.Show("succedded");
                }
            }
            


        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
    }
}
