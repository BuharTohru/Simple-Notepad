using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Simple_Notepad_Plus
{
    public partial class Aboute : Form
    {
        public Aboute()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Aboute_Load(object sender, EventArgs e)
        {
            lblProductName.Text = string.Format("Product Name: {0}", Application.ProductName);
            lblProductVersion.Text = string.Format("Product Version: {0}", Application.ProductVersion);
            lblCopyright.Text = "Copyright © 2021 by @akgnkun";
        }
    }
}
