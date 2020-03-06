namespace AzureLauncher
{
    partial class Form1
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.txtResourceGroupName = new System.Windows.Forms.TextBox();
            this.txtAzureSubscriptionId = new System.Windows.Forms.TextBox();
            this.txtAzureTenantId = new System.Windows.Forms.TextBox();
            this.txtServicePrincipalPassword = new System.Windows.Forms.TextBox();
            this.txtClientID = new System.Windows.Forms.TextBox();
            this.chkPersist = new System.Windows.Forms.CheckBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(3, 68);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1359, 587);
            this.webBrowser1.TabIndex = 0;
            this.webBrowser1.WebBrowserShortcutsEnabled = false;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(1290, 3);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(66, 23);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.button1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Controls.Add(this.webBrowser1, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1365, 658);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel2.Controls.Add(this.txtResourceGroupName, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtAzureSubscriptionId, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtAzureTenantId, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtServicePrincipalPassword, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.txtClientID, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.btnGenerate, 6, 0);
            this.tableLayoutPanel2.Controls.Add(this.chkPersist, 5, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1359, 59);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // txtResourceGroupName
            // 
            this.txtResourceGroupName.Location = new System.Drawing.Point(979, 3);
            this.txtResourceGroupName.Name = "txtResourceGroupName";
            this.txtResourceGroupName.Size = new System.Drawing.Size(238, 20);
            this.txtResourceGroupName.TabIndex = 6;
            this.txtResourceGroupName.Text = "ResourceGroupName";
            // 
            // txtAzureSubscriptionId
            // 
            this.txtAzureSubscriptionId.Location = new System.Drawing.Point(735, 3);
            this.txtAzureSubscriptionId.Name = "txtAzureSubscriptionId";
            this.txtAzureSubscriptionId.Size = new System.Drawing.Size(238, 20);
            this.txtAzureSubscriptionId.TabIndex = 5;
            this.txtAzureSubscriptionId.Text = "AzureSubscriptionId";
            // 
            // txtAzureTenantId
            // 
            this.txtAzureTenantId.Location = new System.Drawing.Point(491, 3);
            this.txtAzureTenantId.Name = "txtAzureTenantId";
            this.txtAzureTenantId.Size = new System.Drawing.Size(238, 20);
            this.txtAzureTenantId.TabIndex = 4;
            this.txtAzureTenantId.Text = "AzureTenantId";
            // 
            // txtServicePrincipalPassword
            // 
            this.txtServicePrincipalPassword.Location = new System.Drawing.Point(247, 3);
            this.txtServicePrincipalPassword.Name = "txtServicePrincipalPassword";
            this.txtServicePrincipalPassword.Size = new System.Drawing.Size(238, 20);
            this.txtServicePrincipalPassword.TabIndex = 3;
            this.txtServicePrincipalPassword.Text = "ServicePrincipalPassword";
            // 
            // txtClientID
            // 
            this.txtClientID.Location = new System.Drawing.Point(3, 3);
            this.txtClientID.Name = "txtClientID";
            this.txtClientID.Size = new System.Drawing.Size(238, 20);
            this.txtClientID.TabIndex = 2;
            this.txtClientID.Text = "ClientId";
            // 
            // chkPersist
            // 
            this.chkPersist.AutoSize = true;
            this.chkPersist.Checked = true;
            this.chkPersist.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkPersist.Location = new System.Drawing.Point(1223, 3);
            this.chkPersist.Name = "chkPersist";
            this.chkPersist.Size = new System.Drawing.Size(57, 17);
            this.chkPersist.TabIndex = 7;
            this.chkPersist.Text = "Persist";
            this.chkPersist.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 682);
            this.Controls.Add(this.tableLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AzureLauncher";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox txtResourceGroupName;
        private System.Windows.Forms.TextBox txtAzureSubscriptionId;
        private System.Windows.Forms.TextBox txtAzureTenantId;
        private System.Windows.Forms.TextBox txtServicePrincipalPassword;
        private System.Windows.Forms.TextBox txtClientID;
        private System.Windows.Forms.CheckBox chkPersist;
    }
}

