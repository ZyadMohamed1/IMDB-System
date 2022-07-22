using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace imdb
{
    public partial class MainForm : Form
    {
        private Thread thread;

        OracleConnection conn;
        string constr = "Data Source = Orcl; User Id = hr; password = hh;";

        public MainForm()
        {
            InitializeComponent();
        }


        //Add and check Rate
        private void button1_Click(object sender, EventArgs e)
        {
            //Make 3 commands ( Select, Update, Insert)
            int x = 0;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;

            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;

            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = conn;

            //Check if the user Rate Before or not (Add or update) the rate
            cmd2.CommandText = "select rate from RATE where userphnum=:ph and movie_id=:id1";
            //Phone number and Movie ID 
            cmd2.Parameters.Add("ph", user_id_txt.Text);
            cmd2.Parameters.Add("id1", mov_ID_txt.Text);

            OracleDataReader dr = cmd2.ExecuteReader();

            //Check If the Rate is found Before
            if (dr.Read())
            {
                
                    x = 1;
                
            }

            dr.Close();
            //Add the rate
            if(x==0)
            {
                cmd.CommandText = "insert into Rate values (:ph,:id1,:rate)";
                //Phone number and Movie ID and Rate
                cmd.Parameters.Add("ph", user_id_txt.Text);
                cmd.Parameters.Add("id1", mov_ID_txt.Text);
                cmd.Parameters.Add("rate", rateBox1.SelectedItem.ToString());

                int r = cmd.ExecuteNonQuery();

                if (r != -1)
                {
                    
                    MessageBox.Show("New Review is Added");
                }
            }
            //Update the Rate found
            else
            {
                cmd3.CommandText = "Update Rate set rate=:rate where userphnum=:ph and movie_id=:id1";
                //Phone number and Movie ID and Rate
                cmd3.Parameters.Add("rate", rateBox1.SelectedItem.ToString());
                cmd3.Parameters.Add("ph", user_id_txt.Text);
                cmd3.Parameters.Add("id1", mov_ID_txt.Text);

                int r = cmd3.ExecuteNonQuery();

                if (r != -1)
                {
                    
                    MessageBox.Show("New Rate Updated");
                }
            }
            

        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            //Save the user ID to be used
            Console.WriteLine(CommonClass.LoginName);
            conn = new OracleConnection(constr);
            conn.Open();
            Console.WriteLine("connection");
            user_id_txt.Text = CommonClass.LoginName;
            


            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            cmd.CommandText = "select User_name from Users where userphnum=:ph";
            cmd.CommandType = CommandType.Text;
            //Phone Number
            cmd.Parameters.Add("ph", user_id_txt.Text);

            //Hello User
            OracleDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Username_txt.Text += dr[0].ToString();
            }

            dr.Close();
        }


        //Add to watchList
        private void button2_Click(object sender, EventArgs e)
        {
            //Contain 2 commands ( Select, Insert)
            int x = 0;
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
            OracleCommand cmd3 = new OracleCommand();
            cmd3.Connection = conn;

            cmd.CommandText = "select movie_id from watch where userphnum=:ph";
            //Phone Number
            cmd.Parameters.Add("ph", user_id_txt.Text);

            OracleDataReader dr = cmd.ExecuteReader();
            //Check If the Movie is found
            while (dr.Read())
            {
                if(mov_ID_txt.Text.ToString()==dr[0].ToString())
                {
                    x = 1;
                   
                }
            }

            dr.Close();
            //Add the review
            if (x == 0)
            {
                cmd.CommandText = "insert into watch values (:ph,:id1)";
                //Phone Number and Movie ID
                cmd.Parameters.Add("ph", user_id_txt.Text);
                cmd.Parameters.Add("id1", mov_ID_txt.Text);

                int r = cmd.ExecuteNonQuery();

                if (r != -1)
                {
                    MessageBox.Show("Movie is Added");
                }
            }
            else
            {
                MessageBox.Show("Movie already exists in your watch list");
            }

        }

        //Show WatchList
        private void button3_Click(object sender, EventArgs e)
        {
           //Access the stored procedure and Retrieve WatchList
            OracleCommand cmd2 = new OracleCommand();
            cmd2.Connection = conn;
            cmd2.CommandText = "mov_i";
            //Phone Number and Movie ID
            cmd2.Parameters.Add("ph1", user_id_txt.Text);
            cmd2.Parameters.Add("mov", OracleDbType.RefCursor, ParameterDirection.Output);
            cmd2.CommandType = CommandType.StoredProcedure;
            OracleDataReader dr2 = cmd2.ExecuteReader();
            watchListView.Text = "Movies:";
            
            while (dr2.Read())
            {
                //Select the movies and show it
                OracleCommand cmd3 = new OracleCommand();
                cmd3.Connection = conn;
                cmd3.CommandText = "select Movie_name from Movies where Movie_ID =:ph1";
                cmd3.Parameters.Add("ph1", dr2[0].ToString());
                cmd3.CommandType = CommandType.Text;
                OracleDataReader dr3 = cmd3.ExecuteReader();
                while (dr3.Read())
                {
                    watchListView.Text += "\n" + dr3[0];
                }

            }
            dr2.Close();
        }

        private void openLoginForm(object obj)
        {
            Application.Run(new LoginForm());
        }

        //Add Review
        private void button4_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = conn;
           
          
            //check if review box is empty or not
            if (String.IsNullOrEmpty(ReviewBox1.Text))
            {
                MessageBox.Show("Text is empty");
            }
            else
            {
                //Add the review
                cmd.CommandText = "insert into Reviews values (:id1,:rev,:ph)";
                //Movie ID, Review, Phone Number
                cmd.Parameters.Add("id1", mov_ID_txt.Text);
                cmd.Parameters.Add("rev", ReviewBox1.Text.ToString());
                cmd.Parameters.Add("ph", user_id_txt.Text);
                int r = cmd.ExecuteNonQuery();

                if (r != -1)
                {

                    MessageBox.Show("Review is Added");
                }
                else
                {
                    MessageBox.Show("Failed to Add Review");
                }
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        //Search Button
        private void search_Click(object sender, EventArgs e)
        {
            OracleCommand cmd = new OracleCommand();
            OracleParameter c = new OracleParameter();
            //check the movie box is not empty
            cmd.Connection = conn;
            if (String.IsNullOrEmpty(movie_name_txt.Text))
            {
                MessageBox.Show("Text is empty");
            }
            //get the info from database
            string name = movie_name_txt.Text;
            //Movie IDs stored Procesure
            cmd.CommandText = "m";
            cmd.Parameters.Add("name", name);
            // n : Movie ID
            // v : Production Year
            cmd.Parameters.Add("n", OracleDbType.Int32, ParameterDirection.Output);
            cmd.Parameters.Add("v", OracleDbType.Int32, ParameterDirection.Output);

            cmd.CommandType = CommandType.StoredProcedure;

            string n = Convert.ToString(cmd.Parameters[1].Value);
            string v = Convert.ToString(cmd.Parameters[2].Value);
            //Seach for the movie
            if (n=="null")
            {
                MessageBox.Show("oops! Coudn't Found the Film");
            }
            else
            {
                mov_ID_txt.Text = n;
                DateBox1.Text = v;
            }

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void DateBox1_TextChanged(object sender, EventArgs e)
        {

        }

        //Logout
        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(logout);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        private void logout()
        {
            Application.Run(new LoginForm());
        }

        //Watch LiST Report
        private void btn_watch_list_rep_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(cr1);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }

        //Film Report
        private void btn_file_report_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(cr2);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
        private void cr1(object obj)
        {
            Application.Run(new crystal1());
        }
        private void cr2(object obj)
        {
            Application.Run(new crystal2());
        }
    }
}

