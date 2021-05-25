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

        public static string signUpInfoPlan = "";

        public SignUpForm2()
        {
            InitializeComponent();
        }

        //private void SignUpForm2_FormClosed(object sender, FormClosedEventArgs e)
        //{
        //    SignUpForm1.Show();
        //    this.Dispose();
        //}

        private void link_Back_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //SignUpForm1.Show();
            this.DialogResult = DialogResult.OK;
        }

        private void btn_Basic_Click(object sender, EventArgs e)
        {
            signUpInfoPlan = "Basic";
            GoToForm3();
            this.Hide();
        }

        private void btn_Standard_Click(object sender, EventArgs e)
        {
            signUpInfoPlan = "Standard";
            GoToForm3();
            this.Hide();
        }

        private void btn_Premium_Click(object sender, EventArgs e)
        {
            signUpInfoPlan = "Premium";
            GoToForm3();
            this.Hide();
        }

        private void GoToForm3()
        {
            SignUpForm3 SignUpForm3 = new SignUpForm3();
            this.Hide();
            SignUpForm3.ShowDialog();
        }
    }
}
