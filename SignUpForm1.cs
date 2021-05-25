using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieHub
{
    public partial class SignUpForm1 : Form
    {
        public static (string firstname, string lastname, 
            string email, string username, 
            string password, string mobileNum) signUpInfo1 = ("","","","","","");

        public SignUpForm1()
        {
            InitializeComponent();
        }

        private void btn_Continue_Click_1(object sender, EventArgs e)
        {
            string firstName = txt_FirstName.Text;
            string lastName = txt_LastName.Text;
            string email = txt_Email.Text;
            string username = txt_Username.Text;
            string password = txt_Password.Text;
            string mobileNum = txt_MobileNum.Text;

            signUpInfo1 = (firstName, lastName, email, username, password, mobileNum);

            SignUpForm2 SignUpForm2 = new SignUpForm2();
            this.Hide();
            SignUpForm2.ShowDialog();
        }

        //private void SignUpForm1_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    LoginForm.Show();
        //    this.Dispose();
        //}

        private void link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //LoginForm.Show();
            this.DialogResult = DialogResult.OK;
        }
    }
}
