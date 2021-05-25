using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MovieHub
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }
        private void Homepage_Load(object sender, EventArgs e)
        {
            var select = "SELECT name, year, director, producer, cast, length, genre FROM movieLibrary";
            var c = new SqlConnection("Data Source =.; Initial Catalog = MovieHub; Integrated Security = True"); // Your Connection String here
            var dataAdapter = new SqlDataAdapter(select, c);

            var commandBuilder = new SqlCommandBuilder(dataAdapter);
            var ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.ReadOnly = true;
            dataGridView1.DataSource = ds.Tables[0];
        }
        private void link_SignOut_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
            this.Hide();
        }

        private void btn_Profile_Click(object sender, EventArgs e)
        {
            Account Account = new Account();
            Account.Show();
            this.Hide();
        }


    }
}
