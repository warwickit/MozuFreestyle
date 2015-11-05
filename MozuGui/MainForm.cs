using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Utilities;

namespace MozuGui
{
    public partial class MainForm : Form
    {
        private MozuFreeStyleInterface.MozuFreeStyleInterface _interface;


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

            //this._btnMozuProductDownload_Click(null, null);
            //this._btnFreestyleProductDownload_Click(null, null);
            //this._btnMozuCustomerDownload_Click(null, null);
            //this._btnFre._btnFreestyleCustomerDownload_Click(null, null);
        }


        private void _worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            _txtOutput.Text += e.UserState.ToString() + Environment.NewLine;
            _txtOutput.SelectionStart = _txtOutput.Text.Length;
            _txtOutput.ScrollToCaret();
        }

        private void _worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            _txtOutput.Text += "Finished!" + Environment.NewLine;
            _txtOutput.SelectionStart = _txtOutput.Text.Length;
            _txtOutput.ScrollToCaret();
        }


        /** product transfers */
        private void _btnMozuProductDownload_Click(object sender, EventArgs e)
        {
            _interface = new MozuFreeStyleInterface.MozuFreeStyleInterface(_txtMozuUser.Text, _txtMozuPassword.Text, _txtFreestyleUser.Text, _txtFreestylePassword.Text);
            BackgroundWorker _worker = new BackgroundWorker() { WorkerSupportsCancellation=true, WorkerReportsProgress=true };
            _worker.DoWork += _btnMozuProductDownload_DoWork;
            _worker.ProgressChanged += _worker_ProgressChanged;
            _worker.RunWorkerCompleted += _worker_RunWorkerCompleted;
            _interface.BackgroundWorker = _worker;
            _worker.RunWorkerAsync();
        }
        private void _btnMozuProductDownload_DoWork(object sender, DoWorkEventArgs e)
        {
            int page = Utility.getInt(_txtProductPage.Text);
            string sku = _txtSku.Text;
            _interface.TransferProductsToMozu(page, sku);
        }
        

        private void _btnFreestyleProductDownload_Click(object sender, EventArgs e)
        {
            _interface = new MozuFreeStyleInterface.MozuFreeStyleInterface(_txtMozuUser.Text, _txtMozuPassword.Text, _txtFreestyleUser.Text, _txtFreestylePassword.Text);
            BackgroundWorker _worker = new BackgroundWorker() { WorkerSupportsCancellation=true, WorkerReportsProgress=true };
            _worker.DoWork += _btnFreestyleProductDownload_DoWork;
            _worker.ProgressChanged += _worker_ProgressChanged;
            _worker.RunWorkerCompleted += _worker_RunWorkerCompleted;
            _interface.BackgroundWorker = _worker;
            _worker.RunWorkerAsync();
        }
        private void _btnFreestyleProductDownload_DoWork(object sender, DoWorkEventArgs e)
        {
            int page = Utility.getInt(_txtProductPage.Text);
            string sku = _txtSku.Text;
            _interface.TransferProductsToFreeStyle();
        }


        /** customer transfers */
        private void _btnMozuCustomerDownload_Click(object sender, EventArgs e)
        {
            _interface = new MozuFreeStyleInterface.MozuFreeStyleInterface(_txtMozuUser.Text, _txtMozuPassword.Text, _txtFreestyleUser.Text, _txtFreestylePassword.Text);
            BackgroundWorker _worker = new BackgroundWorker() { WorkerSupportsCancellation=true, WorkerReportsProgress=true };
            _worker.DoWork += _btnMozuCustomerDownload_DoWork;
            _worker.ProgressChanged += _worker_ProgressChanged;
            _worker.RunWorkerCompleted += _worker_RunWorkerCompleted;
            _interface.BackgroundWorker = _worker;
            _worker.RunWorkerAsync();
        }
        private void _btnMozuCustomerDownload_DoWork(object sender, DoWorkEventArgs e)
        {
            int page = Utility.getInt(_txtCustomerPage.Text);
            _interface.TransferCustomersToMozu(page);
        }


        private void _btnFreestyleCustomerDownload_Click(object sender, EventArgs e)
        {
            _interface = new MozuFreeStyleInterface.MozuFreeStyleInterface(_txtMozuUser.Text, _txtMozuPassword.Text, _txtFreestyleUser.Text, _txtFreestylePassword.Text);
            BackgroundWorker _worker = new BackgroundWorker() { WorkerSupportsCancellation=true, WorkerReportsProgress=true };
            _worker.DoWork += _btnFreestyleCustomerDownload_DoWork;
            _worker.ProgressChanged += _worker_ProgressChanged;
            _worker.RunWorkerCompleted += _worker_RunWorkerCompleted;
            _interface.BackgroundWorker = _worker;
            _worker.RunWorkerAsync();
        }
        private void _btnFreestyleCustomerDownload_DoWork(object sender, DoWorkEventArgs e)
        {
            int page = Utility.getInt(_txtCustomerPage.Text);
            _interface.TransferCustomersToFreeStyle(page);
        }


        /** order transfers */
        private void _btnMozuOrderDownload_Click(object sender, EventArgs e)
        {
            _interface = new MozuFreeStyleInterface.MozuFreeStyleInterface(_txtMozuUser.Text, _txtMozuPassword.Text, _txtFreestyleUser.Text, _txtFreestylePassword.Text);
            BackgroundWorker _worker = new BackgroundWorker() { WorkerSupportsCancellation=true, WorkerReportsProgress=true };
            _worker.DoWork += _btnMozuOrderDownload_DoWork;
            _worker.ProgressChanged += _worker_ProgressChanged;
            _worker.RunWorkerCompleted += _worker_RunWorkerCompleted;
            _interface.BackgroundWorker = _worker;
            _worker.RunWorkerAsync();
        }
        private void _btnMozuOrderDownload_DoWork(object sender, DoWorkEventArgs e)
        {
            int page = Utility.getInt(_txtOrderPage.Text);
            string orderNumber = _txtOrderNumber.Text;
            _interface.TransferOrdersToMozu(page, orderNumber);
        }

        private void _btnFreestyleOrderDownload_Click(object sender, EventArgs e)
        {
            _interface = new MozuFreeStyleInterface.MozuFreeStyleInterface(_txtMozuUser.Text, _txtMozuPassword.Text, _txtFreestyleUser.Text, _txtFreestylePassword.Text);
            BackgroundWorker _worker = new BackgroundWorker() { WorkerSupportsCancellation=true, WorkerReportsProgress=true };
            _worker.DoWork += _btnFreestyleOrderDownload_DoWork;
            _worker.ProgressChanged += _worker_ProgressChanged;
            _worker.RunWorkerCompleted += _worker_RunWorkerCompleted;
            _interface.BackgroundWorker = _worker;
            _worker.RunWorkerAsync();
        }
        private void _btnFreestyleOrderDownload_DoWork(object sender, DoWorkEventArgs e)
        {
            int page = Utility.getInt(_txtOrderPage.Text);
            string orderNumber = _txtOrderNumber.Text;
            _interface.TransferOrdersToFreestyle(page, orderNumber);
        }


        /** ship confirm transfers */
        private void _btnFreestyleShipConfirm_Click(object sender, EventArgs e)
        {
            _interface = new MozuFreeStyleInterface.MozuFreeStyleInterface(_txtMozuUser.Text, _txtMozuPassword.Text, _txtFreestyleUser.Text, _txtFreestylePassword.Text);
            BackgroundWorker _worker = new BackgroundWorker() { WorkerSupportsCancellation=true, WorkerReportsProgress=true };
            _worker.DoWork += _btnFreestyleShipConfirm_DoWork;
            _worker.ProgressChanged += _worker_ProgressChanged;
            _worker.RunWorkerCompleted += _worker_RunWorkerCompleted;
            _interface.BackgroundWorker = _worker;
            _worker.RunWorkerAsync();
        }
        private void _btnFreestyleShipConfirm_DoWork(object sender, DoWorkEventArgs e)
        {
            int page = Utility.getInt(_txtProductPage.Text);
            string sku = _txtSku.Text;
            _interface.TransferShipmentConfirmationsToMozu();
        }


    }
}
