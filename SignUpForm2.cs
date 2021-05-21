using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieHub
{
    public partial class SignUpForm2 : Form
    {
        public SignUpForm2()
        {
            InitializeComponent();
        }

        private void btn_Continue_Click(object sender, EventArgs e)
        {
            SignUpForm3 SignUpForm3 = new SignUpForm3();
            SignUpForm3.Show();
            this.Hide();
        }

        private void link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm1 SignUpForm1 = new SignUpForm1();
            SignUpForm1.Show();
            this.Hide();
        }
    }
}
