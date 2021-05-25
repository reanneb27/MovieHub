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
    public partial class LoginForm : Form
    {

        public static (string, string, string, string, string) signUpInfo;

        SqlConnection connectionString = new SqlConnection(@"Data Source=.;Initial Catalog=MovieHub;Integrated Security=True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        //ID variable used in Updating and Deleting Record  
        int ID = 0;
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            //SqlConnection connectionString = new SqlConnection(@"Data Source=.;Initial Catalog=MovieHub;Integrated Security=True");
            string query = "SELECT * FROM login WHERE username = '" + txt_Username.Text.Trim() + "' AND password = '" + txt_Password.Text.Trim() + "'";
            adapter = new SqlDataAdapter(query, connectionString);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);

            if (dataTable.Rows.Count == 1)
            {
                Homepage Homepage = new Homepage();
                this.Hide();
                Homepage.Show();
            }
            else
            {
                MessageBox.Show("Invalid email or password");
            }
        }

        private void link_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm1 SignUpForm1 = new SignUpForm1();
            this.Hide();
            SignUpForm1.ShowDialog();
        }

        private void txt_Username_Click(object sender, EventArgs e)
        {
            txt_Username.Clear();
        }

        private void txt_Password_Click(object sender, EventArgs e)
        {
            txt_Password.UseSystemPasswordChar = true;
            txt_Password.Clear();
        }
    }
}
