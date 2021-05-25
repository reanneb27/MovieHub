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
        public SignUpForm3()
        {
            InitializeComponent();
        }

        private void btn_Visa_Click(object sender, EventArgs e)
        {
            string payMethod = "Visa";
            SignUpForm4 SignUpForm4 = new SignUpForm4();
            SignUpForm4.Show();
            this.Hide();
        }
        private void btn_MasterCard_Click(object sender, EventArgs e)
        {
            string payMethod = "MasterCard";
            SignUpForm4 SignUpForm4 = new SignUpForm4();
            SignUpForm4.Show();
            this.Hide();
        }
        private void link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm2 SignUpForm2 = new SignUpForm2();
            SignUpForm2.Show();
            this.Hide();
        }


    }
}
