using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MovieHub
{
    public partial class Account : Form
    {
        public Account()
        {
            InitializeComponent();
        }

        private void lbl_Back_Click(object sender, EventArgs e)
        {
            Homepage Homepage = new Homepage();
            Homepage.Show();
            this.Hide();
        }

        private void Account_Load(object sender, EventArgs e)
        {

        }
    }
}
