using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Notepadd
{
    public partial class About : Form
    {
        public About()
        {
            InitializeComponent();
        }

        private void About_Load(object sender, EventArgs e)
        {
            lblProductName.Text = string.Format("Product name : {0}", Application.ProductName);
            lblProductVersion.Text = string.Format("Version : {0}", Application.ProductVersion);
            lblCopyright.Text = string.Format("Copyright ©  2021 by Tarık ŞEN");
        }
    }
}
