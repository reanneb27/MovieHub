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
            string firstNameCN = txt_FirstNameCN.Text;
            string lastNameCN = txt_LastNameCN.Text;
            int zipCode = Convert.ToInt32(txt_ZipCode.Text);
            int cardNo = Convert.ToInt32(txt_CardNo.Text);
            string expirationDate = Convert.ToInt32(txt_Month) + "-" + Convert.ToInt32(txt_Year);
            int CVV = Convert.ToInt32(txt_CVV);

            Homepage Homepage = new Homepage();
            Homepage.Show();
            this.Hide();
        }
    }
}
