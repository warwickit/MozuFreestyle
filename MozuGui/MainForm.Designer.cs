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
            this.label1 = new System.Windows.Forms.Label();
            this._txtMozuUser = new System.Windows.Forms.TextBox();
            this._txtMozuPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this._txtFreestyleUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this._txtFreestylePassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this._btnMozuProductDownload = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.groupBox1.Size = new System.Drawing.Size(647, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Login Credentials";
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
            // _txtMozuUser
            // 
            this._txtMozuUser.Location = new System.Drawing.Point(115, 30);
            this._txtMozuUser.Name = "_txtMozuUser";
            this._txtMozuUser.Size = new System.Drawing.Size(169, 20);
            this._txtMozuUser.TabIndex = 1;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this._btnMozuProductDownload);
            this.groupBox2.Location = new System.Drawing.Point(12, 131);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(647, 114);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Product Transfer";
            // 
            // _btnMozuProductDownload
            // 
            this._btnMozuProductDownload.Location = new System.Drawing.Point(272, 44);
            this._btnMozuProductDownload.Name = "_btnMozuProductDownload";
            this._btnMozuProductDownload.Size = new System.Drawing.Size(114, 23);
            this._btnMozuProductDownload.TabIndex = 0;
            this._btnMozuProductDownload.Text = "Freestyle -> Mozu";
            this._btnMozuProductDownload.UseVisualStyleBackColor = true;
            this._btnMozuProductDownload.Click += new System.EventHandler(this._btnMozuProductDownload_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(671, 483);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Mozu-Freestyle Interface";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
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
    }
}

