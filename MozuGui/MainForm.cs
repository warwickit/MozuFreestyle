using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MozuGui
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }


        private void MainForm_Load(object sender, EventArgs e)
        {
            _txtMozuUser.Text = "warwickfulfillmentit@gmail.com";
            _txtMozuPassword.Text = "8cba69dfa4";
            _txtFreestyleUser.Text = "mozu@warwickfulfillment.com";
            _txtFreestylePassword.Text = "7mwMIN5!go5Y";

            this._btnMozuProductDownload_Click(null, null);
        }


        private void _btnMozuProductDownload_Click(object sender, EventArgs e)
        {

        }


    }
}
