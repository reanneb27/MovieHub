﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieHub
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            Homepage Homepage = new Homepage();
            Homepage.Show();
            this.Hide();
        }

        private void link_SignUp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm1 SignUpForm1 = new SignUpForm1();
            SignUpForm1.Show();
            this.Hide();
        }
    }
}
