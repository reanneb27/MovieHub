using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieHub
{
    public partial class SignUpForm3 : Form
    {
        public static string signUpInfoPayMethod = "";

        public SignUpForm3()
        {
            InitializeComponent();
        }

        private void btn_Visa_Click(object sender, EventArgs e)
        {
            signUpInfoPayMethod = "Visa";
            StoreToDatabase();
            
            this.Hide();
        }
        private void btn_MasterCard_Click(object sender, EventArgs e)
        {
            signUpInfoPayMethod = "MasterCard";
            StoreToDatabase();
            this.Hide();
        }

        //private void SignUpForm3_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    SignUpForm2.Show();
        //    this.Dispose();
        //}

        private void link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm2 SignUpForm2 = new SignUpForm2();
            SignUpForm2.Show();
            this.Close();
        }

        private void StoreToDatabase()
        {
            var (firstname, lastname, email, username, password, mobileNum) = SignUpForm1.signUpInfo1;
            string plan = SignUpForm2.signUpInfoPlan;
            string payMethod = signUpInfoPayMethod;

            // SQL Query to Insert data

            LoginForm LoginForm = new LoginForm();
            LoginForm.txt_Username.Text = username;
            LoginForm.txt_Password.Text = password;
            LoginForm.Show();

            this.DialogResult = DialogResult.OK;
        }

    }
}
