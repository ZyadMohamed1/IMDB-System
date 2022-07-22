using System;
using System.Windows.Forms;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;



namespace imdb
{

    public static class CommonClass
    {
        public static string LoginName;
       // public string LoginUserName { get; set; }
    }

    public partial class LoginForm : Form
    {
        private Thread thread;
        string ordb = "Data source=orcl;User Id=hr;Password=hh;";
        OracleConnection conn;

        public LoginForm()
        {
            InitializeComponent();
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            thread = new Thread(openRegisterForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
       
            
        }

        private void openRegisterForm(object obj)
        {
            Application.Run(new RegisterForm());
        }


        private void btn_login_Click(object sender, EventArgs e)
        {

            //Check if the password or Phone Number is empty
            if(String.IsNullOrEmpty(tb_phone_numbe.Text) || String.IsNullOrEmpty(tb_password.Text))
            {
                MessageBox.Show("please check the empty field", "Login Failed ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                //TODO:Go to database
                //Check if the login person is user or Admin
                OracleCommand cmd = new OracleCommand();
                cmd.Connection = conn;
                cmd.CommandText = "select admin_pass,admin_name from Admins where adminphnum=:ph";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add("ph", tb_phone_numbe.Text);
                OracleDataReader dr = cmd.ExecuteReader();
                OracleCommand cmd1 = new OracleCommand();
                cmd1.Connection = conn;
                cmd1.CommandText = "select USER_PASS,user_name from Users where USERPHNUM=:ph1";
                cmd1.CommandType = CommandType.Text;
                cmd1.Parameters.Add("ph1", tb_phone_numbe.Text);
                OracleDataReader dr1 = cmd1.ExecuteReader();
                CommonClass.LoginName = tb_phone_numbe.Text;
                Console.WriteLine("dr");

                if (dr.Read())
                {
                    Console.WriteLine("dddddddrrrrrrrrrrr");
                     //Open the Admin form
                     string admin_pass = dr["admin_pass"].ToString();
                     if (admin_pass == tb_password.Text.ToString())
                     {
                         this.Close();
                         thread = new Thread(openAdminForm);
                         thread.SetApartmentState(ApartmentState.STA);
                         thread.Start();
                     }
                     else
                     {
                         MessageBox.Show("invalid password", "Login Failed ",
                         MessageBoxButtons.OK,
                         MessageBoxIcon.Error);
                     }
                }

                //Open the User Form
                if(dr1.Read())
                {
                    Console.WriteLine("dddddddrrrrrrrrrrr1111111");
                    string user_pass = dr1["User_pass"].ToString();
                    if (user_pass == tb_password.Text.ToString())
                    {
                        
                        this.Close();
                        thread = new Thread(openMainForm);
                        thread.SetApartmentState(ApartmentState.STA);
                        thread.Start();
                    }
                    else
                    {
                        MessageBox.Show("invalid password", "Login Failed ",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    }
                }

                dr.Close();

            }
        }
        private void openAdminForm(object obj)
        {
            Application.Run(new AdminForm());
        }

        private void openMainForm(object obj)
        {
            Application.Run(new MainForm());
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(ordb);
            conn.Open();
        }
    }


    
}
