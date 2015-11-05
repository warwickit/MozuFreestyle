namespace MozuGui
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._txtFreestylePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this._txtFreestyleUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtMozuPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtMozuUser = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._txtSku = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this._txtProductPage = new System.Windows.Forms.TextBox();
            this._btnFreestyleProductDownload = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this._btnMozuProductDownload = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this._txtOutput = new System.Windows.Forms.RichTextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this._txtCustomerPage = new System.Windows.Forms.TextBox();
            this._btnFreestyleCustomerDownload = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this._btnMozuCustomerDownload = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this._btnFreestyleShipConfirm = new System.Windows.Forms.Button();
            this._txtOrderNumber = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this._txtOrderPage = new System.Windows.Forms.TextBox();
            this._btnFreestyleOrderDownload = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this._btnMozuOrderDownload = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this._txtFreestylePassword);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this._txtFreestyleUser);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this._txtMozuPassword);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this._txtMozuUser);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1037, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Credentials";
            // 
            // _txtFreestylePassword
            // 
            this._txtFreestylePassword.Location = new System.Drawing.Point(416, 60);
            this._txtFreestylePassword.Name = "_txtFreestylePassword";
            this._txtFreestylePassword.Size = new System.Drawing.Size(215, 20);
            this._txtFreestylePassword.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(309, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Freestyle Password:";
            // 
            // _txtFreestyleUser
            // 
            this._txtFreestyleUser.Location = new System.Drawing.Point(416, 30);
            this._txtFreestyleUser.Name = "_txtFreestyleUser";
            this._txtFreestyleUser.Size = new System.Drawing.Size(215, 20);
            this._txtFreestyleUser.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(309, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Freestyle User:";
            // 
            // _txtMozuPassword
            // 
            this._txtMozuPassword.Location = new System.Drawing.Point(115, 60);
            this._txtMozuPassword.Name = "_txtMozuPassword";
            this._txtMozuPassword.Size = new System.Drawing.Size(169, 20);
            this._txtMozuPassword.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Mozu Password:";
            // 
            // _txtMozuUser
            // 
            this._txtMozuUser.Location = new System.Drawing.Point(115, 30);
            this._txtMozuUser.Name = "_txtMozuUser";
            this._txtMozuUser.Size = new System.Drawing.Size(169, 20);
            this._txtMozuUser.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mozu User:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._txtSku);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this._txtProductPage);
            this.groupBox2.Controls.Add(this._btnFreestyleProductDownload);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this._btnMozuProductDownload);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(481, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Transfer";
            // 
            // _txtSku
            // 
            this._txtSku.Location = new System.Drawing.Point(65, 67);
            this._txtSku.Name = "_txtSku";
            this._txtSku.Size = new System.Drawing.Size(99, 20);
            this._txtSku.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 70);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Sku:";
            // 
            // _txtProductPage
            // 
            this._txtProductPage.Location = new System.Drawing.Point(65, 27);
            this._txtProductPage.Name = "_txtProductPage";
            this._txtProductPage.Size = new System.Drawing.Size(36, 20);
            this._txtProductPage.TabIndex = 9;
            // 
            // _btnFreestyleProductDownload
            // 
            this._btnFreestyleProductDownload.Location = new System.Drawing.Point(326, 42);
            this._btnFreestyleProductDownload.Name = "_btnFreestyleProductDownload";
            this._btnFreestyleProductDownload.Size = new System.Drawing.Size(114, 37);
            this._btnFreestyleProductDownload.TabIndex = 1;
            this._btnFreestyleProductDownload.Text = "Mozu to Freestyle";
            this._btnFreestyleProductDownload.UseVisualStyleBackColor = true;
            this._btnFreestyleProductDownload.Click += new System.EventHandler(this._btnFreestyleProductDownload_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 30);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Page:";
            // 
            // _btnMozuProductDownload
            // 
            this._btnMozuProductDownload.Location = new System.Drawing.Point(192, 42);
            this._btnMozuProductDownload.Name = "_btnMozuProductDownload";
            this._btnMozuProductDownload.Size = new System.Drawing.Size(114, 37);
            this._btnMozuProductDownload.TabIndex = 0;
            this._btnMozuProductDownload.Text = "Freestyle to Mozu";
            this._btnMozuProductDownload.UseVisualStyleBackColor = true;
            this._btnMozuProductDownload.Click += new System.EventHandler(this._btnMozuProductDownload_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this._txtOutput);
            this.groupBox3.Location = new System.Drawing.Point(12, 406);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1037, 331);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Output";
            // 
            // _txtOutput
            // 
            this._txtOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this._txtOutput.Location = new System.Drawing.Point(3, 16);
            this._txtOutput.Name = "_txtOutput";
            this._txtOutput.Size = new System.Drawing.Size(1031, 312);
            this._txtOutput.TabIndex = 0;
            this._txtOutput.Text = "";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this._txtCustomerPage);
            this.groupBox4.Controls.Add(this._btnFreestyleCustomerDownload);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this._btnMozuCustomerDownload);
            this.groupBox4.Location = new System.Drawing.Point(525, 131);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(524, 114);
            this.groupBox4.TabIndex = 12;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Customer Transfer";
            // 
            // _txtCustomerPage
            // 
            this._txtCustomerPage.Location = new System.Drawing.Point(65, 27);
            this._txtCustomerPage.Name = "_txtCustomerPage";
            this._txtCustomerPage.Size = new System.Drawing.Size(36, 20);
            this._txtCustomerPage.TabIndex = 9;
            // 
            // _btnFreestyleCustomerDownload
            // 
            this._btnFreestyleCustomerDownload.Location = new System.Drawing.Point(326, 42);
            this._btnFreestyleCustomerDownload.Name = "_btnFreestyleCustomerDownload";
            this._btnFreestyleCustomerDownload.Size = new System.Drawing.Size(114, 37);
            this._btnFreestyleCustomerDownload.TabIndex = 1;
            this._btnFreestyleCustomerDownload.Text = "Mozu to Freestyle";
            this._btnFreestyleCustomerDownload.UseVisualStyleBackColor = true;
            this._btnFreestyleCustomerDownload.Click += new System.EventHandler(this._btnFreestyleCustomerDownload_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 8;
            this.label8.Text = "Page:";
            // 
            // _btnMozuCustomerDownload
            // 
            this._btnMozuCustomerDownload.Location = new System.Drawing.Point(180, 42);
            this._btnMozuCustomerDownload.Name = "_btnMozuCustomerDownload";
            this._btnMozuCustomerDownload.Size = new System.Drawing.Size(114, 37);
            this._btnMozuCustomerDownload.TabIndex = 0;
            this._btnMozuCustomerDownload.Text = "Freestyle to Mozu";
            this._btnMozuCustomerDownload.UseVisualStyleBackColor = true;
            this._btnMozuCustomerDownload.Click += new System.EventHandler(this._btnMozuCustomerDownload_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this._btnFreestyleShipConfirm);
            this.groupBox5.Controls.Add(this._txtOrderNumber);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this._txtOrderPage);
            this.groupBox5.Controls.Add(this._btnFreestyleOrderDownload);
            this.groupBox5.Controls.Add(this.label9);
            this.groupBox5.Controls.Add(this._btnMozuOrderDownload);
            this.groupBox5.Location = new System.Drawing.Point(15, 263);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(1031, 114);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Order Transfer";
            // 
            // _btnFreestyleShipConfirm
            // 
            this._btnFreestyleShipConfirm.Location = new System.Drawing.Point(703, 42);
            this._btnFreestyleShipConfirm.Name = "_btnFreestyleShipConfirm";
            this._btnFreestyleShipConfirm.Size = new System.Drawing.Size(114, 37);
            this._btnFreestyleShipConfirm.TabIndex = 12;
            this._btnFreestyleShipConfirm.Text = "Ship Confirm";
            this._btnFreestyleShipConfirm.UseVisualStyleBackColor = true;
            this._btnFreestyleShipConfirm.Click += new System.EventHandler(this._btnFreestyleShipConfirm_Click);
            // 
            // _txtOrderNumber
            // 
            this._txtOrderNumber.Location = new System.Drawing.Point(76, 67);
            this._txtOrderNumber.Name = "_txtOrderNumber";
            this._txtOrderNumber.Size = new System.Drawing.Size(99, 20);
            this._txtOrderNumber.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Order #:";
            // 
            // _txtOrderPage
            // 
            this._txtOrderPage.Location = new System.Drawing.Point(76, 27);
            this._txtOrderPage.Name = "_txtOrderPage";
            this._txtOrderPage.Size = new System.Drawing.Size(36, 20);
            this._txtOrderPage.TabIndex = 9;
            // 
            // _btnFreestyleOrderDownload
            // 
            this._btnFreestyleOrderDownload.Location = new System.Drawing.Point(550, 42);
            this._btnFreestyleOrderDownload.Name = "_btnFreestyleOrderDownload";
            this._btnFreestyleOrderDownload.Size = new System.Drawing.Size(114, 37);
            this._btnFreestyleOrderDownload.TabIndex = 1;
            this._btnFreestyleOrderDownload.Text = "Mozu to Freestyle";
            this._btnFreestyleOrderDownload.UseVisualStyleBackColor = true;
            this._btnFreestyleOrderDownload.Click += new System.EventHandler(this._btnFreestyleOrderDownload_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(24, 30);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Page:";
            // 
            // _btnMozuOrderDownload
            // 
            this._btnMozuOrderDownload.Location = new System.Drawing.Point(382, 42);
            this._btnMozuOrderDownload.Name = "_btnMozuOrderDownload";
            this._btnMozuOrderDownload.Size = new System.Drawing.Size(114, 37);
            this._btnMozuOrderDownload.TabIndex = 0;
            this._btnMozuOrderDownload.Text = "Freestyle to Mozu";
            this._btnMozuOrderDownload.UseVisualStyleBackColor = true;
            this._btnMozuOrderDownload.Click += new System.EventHandler(this._btnMozuOrderDownload_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 749);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Mozu-Freestyle Interface";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox _txtFreestylePassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox _txtFreestyleUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _txtMozuPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox _txtMozuUser;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button _btnMozuProductDownload;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox _txtSku;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox _txtProductPage;
        private System.Windows.Forms.Button _btnFreestyleProductDownload;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox _txtOutput;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox _txtCustomerPage;
        private System.Windows.Forms.Button _btnFreestyleCustomerDownload;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button _btnMozuCustomerDownload;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox _txtOrderNumber;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox _txtOrderPage;
        private System.Windows.Forms.Button _btnFreestyleOrderDownload;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button _btnMozuOrderDownload;
        private System.Windows.Forms.Button _btnFreestyleShipConfirm;
    }
}

