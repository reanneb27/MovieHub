using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieHub
{
    public partial class SignUpForm4 : Form
    {
        public SignUpForm4()
        {
            InitializeComponent();
        }

        private void link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SignUpForm3 SignUpForm3 = new SignUpForm3();
            SignUpForm3.Show();
            this.Hide();
        }

        private void btn_Finish_Click(object sender, EventArgs e)
        {
            Homepage Homepage = new Homepage();
            Homepage.Show();
            this.Hide();
        }
    }
}
