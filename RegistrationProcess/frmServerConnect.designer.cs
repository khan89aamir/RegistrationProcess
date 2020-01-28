namespace RegistrationProcess
{
    partial class frmServerConnect
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmServerConnect));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboAuthenticationType = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.grpDBRestore = new System.Windows.Forms.GroupBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnRestore = new System.Windows.Forms.Button();
            this.txtDabasePath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.grpDBRestore.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(49, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Server Name :";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboAuthenticationType);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(52, 171);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(308, 70);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Server Type :";
            // 
            // cboAuthenticationType
            // 
            this.cboAuthenticationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthenticationType.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboAuthenticationType.FormattingEnabled = true;
            this.cboAuthenticationType.Items.AddRange(new object[] {
            "Server",
            "Client"});
            this.cboAuthenticationType.Location = new System.Drawing.Point(54, 27);
            this.cboAuthenticationType.Name = "cboAuthenticationType";
            this.cboAuthenticationType.Size = new System.Drawing.Size(211, 23);
            this.cboAuthenticationType.TabIndex = 12;
            this.cboAuthenticationType.SelectionChangeCommitted += new System.EventHandler(this.cboAuthenticationType_SelectionChangeCommitted);
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(149, 81);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(178, 22);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtPassword.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password :";
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(149, 48);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(178, 22);
            this.txtUserID.TabIndex = 1;
            this.txtUserID.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtUserID.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "User ID :";
            // 
            // btnConnect
            // 
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConnect.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(148, 119);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 25);
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            this.btnConnect.MouseEnter += new System.EventHandler(this.btnConnect_MouseEnter);
            this.btnConnect.MouseLeave += new System.EventHandler(this.btnConnect_MouseLeave);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(252, 119);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 25);
            this.btnClear.TabIndex = 7;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            this.btnClear.MouseEnter += new System.EventHandler(this.btnConnect_MouseEnter);
            this.btnClear.MouseLeave += new System.EventHandler(this.btnConnect_MouseLeave);
            // 
            // txtServerName
            // 
            this.txtServerName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerName.Location = new System.Drawing.Point(149, 20);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(178, 22);
            this.txtServerName.TabIndex = 0;
            this.txtServerName.Enter += new System.EventHandler(this.textBox1_Enter);
            this.txtServerName.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // grpDBRestore
            // 
            this.grpDBRestore.BackColor = System.Drawing.Color.Transparent;
            this.grpDBRestore.Controls.Add(this.btnBrowse);
            this.grpDBRestore.Controls.Add(this.btnRestore);
            this.grpDBRestore.Controls.Add(this.txtDabasePath);
            this.grpDBRestore.Controls.Add(this.label2);
            this.grpDBRestore.Enabled = false;
            this.grpDBRestore.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDBRestore.Location = new System.Drawing.Point(52, 255);
            this.grpDBRestore.Name = "grpDBRestore";
            this.grpDBRestore.Size = new System.Drawing.Size(332, 147);
            this.grpDBRestore.TabIndex = 12;
            this.grpDBRestore.TabStop = false;
            this.grpDBRestore.Text = "Restore Databsae";
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBrowse.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowse.Location = new System.Drawing.Point(243, 23);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(75, 25);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            this.btnBrowse.MouseEnter += new System.EventHandler(this.btnConnect_MouseEnter);
            this.btnBrowse.MouseLeave += new System.EventHandler(this.btnConnect_MouseLeave);
            // 
            // btnRestore
            // 
            this.btnRestore.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRestore.Enabled = false;
            this.btnRestore.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestore.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRestore.Location = new System.Drawing.Point(240, 107);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.Size = new System.Drawing.Size(75, 25);
            this.btnRestore.TabIndex = 6;
            this.btnRestore.Text = "Restore";
            this.btnRestore.UseVisualStyleBackColor = true;
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            this.btnRestore.MouseEnter += new System.EventHandler(this.btnConnect_MouseEnter);
            this.btnRestore.MouseLeave += new System.EventHandler(this.btnConnect_MouseLeave);
            // 
            // txtDabasePath
            // 
            this.txtDabasePath.BackColor = System.Drawing.Color.White;
            this.txtDabasePath.Location = new System.Drawing.Point(6, 68);
            this.txtDabasePath.Name = "txtDabasePath";
            this.txtDabasePath.ReadOnly = true;
            this.txtDabasePath.Size = new System.Drawing.Size(319, 26);
            this.txtDabasePath.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(11, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "Browse Database To Restore :";
            // 
            // frmServerConnect
            // 
            this.AcceptButton = this.btnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(434, 417);
            this.Controls.Add(this.grpDBRestore);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtServerName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmServerConnect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect to server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServerConnect_FormClosing);
            this.Load += new System.EventHandler(this.frmServerConnect_Load);
            this.groupBox1.ResumeLayout(false);
            this.grpDBRestore.ResumeLayout(false);
            this.grpDBRestore.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.ComboBox cboAuthenticationType;
        private System.Windows.Forms.GroupBox grpDBRestore;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnRestore;
        private System.Windows.Forms.TextBox txtDabasePath;
        private System.Windows.Forms.Label label2;
    }
}

