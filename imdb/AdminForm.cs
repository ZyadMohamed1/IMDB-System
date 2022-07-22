using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace imdb
{
    public partial class AdminForm : Form
    {
        private Thread thread;
        OracleDataAdapter adapter;
        DataSet ds;

        OracleConnection conn;
        string constr = "Data Source = Orcl; User Id = hr; password = hh;";

        public AdminForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new OracleConnection(constr);
            conn.Open();
            Console.WriteLine("connection");
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select movie_id from Rate";
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            Console.WriteLine("dr");
            //Add movies to the Combobox
            while (dr.Read())
            {
                var count = comboBox1.Items.Count;

                int cnt = 0;
                for (int i = 0; i < count; i++)
                {
                    if (dr[0].ToString() == comboBox1.Items[i].ToString())
                    {
                        cnt = 1;
                    }
                }

                if (cnt == 0)
                {
                    comboBox1.Items.Add(dr[0]);
                }
            }

            dr.Close();
        }


        private void ShowButton_Click(object sender, EventArgs e)
        {
            Console.WriteLine(CommonClass.LoginName);
            string constr = "Data Source = Orcl; User Id = hr; password = hh;";
            string cmdstr = "";

            //check the radiobox
            if (MovieCheck.Checked)
            {
                //Add the Movie Data
                cmdstr = "select * from Movies";
            }
            else if (viewReviewCheck.Checked)
            {
                //Add the Movie Reviews
                cmdstr = "select * from Reviews";
            }


            adapter = new OracleDataAdapter(cmdstr, constr);
            ds = new DataSet();
            adapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0];
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            OracleCommandBuilder builder = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
        }

        private void viewReviewCheck_CheckedChanged(object sender, EventArgs e)
        {

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

        private void bnt_showRate_Click(object sender, EventArgs e)
        {
            //get the rates of movie from data
            int rate = 0;
            int sum = 0;
            int count = 0;
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "calc_rate";
            cmd2.Parameters.Add("mov_id", comboBox1.SelectedItem.ToString());
            cmd2.Parameters.Add("rate", OracleDbType.RefCursor, ParameterDirection.Output);
            cmd2.CommandType = CommandType.StoredProcedure;
            OracleDataReader dr2 = cmd2.ExecuteReader();
            Console.WriteLine("dr");
            //Calculate the average rate
            while (dr2.Read())
            {
                sum += int.Parse(dr2[0].ToString());
                count++;
            }
            rate = sum / count;
            LB_rate.Text = Convert.ToString(rate);
        }


    }
}
