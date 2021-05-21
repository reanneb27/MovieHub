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
        public SignUpForm1()
        {
            InitializeComponent();
        }
        private void btn_Continue_Click_1(object sender, EventArgs e)
        {
            SignUpForm2 SignUpForm2 = new SignUpForm2();
            SignUpForm2.Show();
            this.Hide();
        }

        private void link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
            this.Hide();
        }
    }
}
