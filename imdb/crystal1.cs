using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.Shared;
using System.Threading;

namespace imdb
{
    public partial class crystal1 : Form
    {
        private Thread thread;
        CrystalReport1 CR;
        public crystal1()
        {
            InitializeComponent();
        }

        private void crystal1_Load(object sender, EventArgs e)
        {
            CR = new CrystalReport1();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int parsedValue;
            if (!int.TryParse(textBox1.Text, out parsedValue))
            {
                MessageBox.Show("This is a number only field");
                return;
            }
            CR.SetParameterValue(0, textBox1.Text);
            crystalReportViewer1.ReportSource = CR;
        }
        private void back(object obj)
        {
            Application.Run(new MainForm());
        }

        private void btn_Back_Click(object sender, EventArgs e)
        {
            this.Close();
            thread = new Thread(back);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        }
    }
}
