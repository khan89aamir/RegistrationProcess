namespace RegistrationProcess
{
    partial class frmCustomerRegister
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerRegister));
            this.txtEncKey = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOrganisation = new System.Windows.Forms.TextBox();
            this.txtMobileNo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnActivate = new System.Windows.Forms.Button();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpExpiryDate = new System.Windows.Forms.DateTimePicker();
            this.Istrial = new System.Windows.Forms.CheckBox();
            this.txtAddress = new System.Windows.Forms.RichTextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtEncKey
            // 
            this.txtEncKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEncKey.BackColor = System.Drawing.Color.White;
            this.txtEncKey.Enabled = false;
            this.txtEncKey.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.txtEncKey.Location = new System.Drawing.Point(44, 393);
            this.txtEncKey.Name = "txtEncKey";
            this.txtEncKey.ReadOnly = true;
            this.txtEncKey.Size = new System.Drawing.Size(366, 25);
            this.txtEncKey.TabIndex = 9;
            this.txtEncKey.Enter += new System.EventHandler(this.MouseFoucsEnter);
            this.txtEncKey.Leave += new System.EventHandler(this.MouseFoucsLeave);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(209, 355);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(80, 26);
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Customer Name :";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtCustomerName.BackColor = System.Drawing.Color.White;
            this.txtCustomerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCustomerName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(138, 54);
            this.txtCustomerName.MaxLength = 25;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(235, 25);
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.Enter += new System.EventHandler(this.MouseFoucsEnter);
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            this.txtCustomerName.Leave += new System.EventHandler(this.MouseFoucsLeave);
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductName.BackColor = System.Drawing.Color.White;
            this.txtProductName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProductName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(138, 92);
            this.txtProductName.MaxLength = 25;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(235, 25);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.Enter += new System.EventHandler(this.MouseFoucsEnter);
            this.txtProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            this.txtProductName.Leave += new System.EventHandler(this.MouseFoucsLeave);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Product Name :";
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(20, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Organisation :";
            // 
            // txtOrganisation
            // 
            this.txtOrganisation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrganisation.BackColor = System.Drawing.Color.White;
            this.txtOrganisation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOrganisation.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganisation.Location = new System.Drawing.Point(138, 125);
            this.txtOrganisation.MaxLength = 25;
            this.txtOrganisation.Name = "txtOrganisation";
            this.txtOrganisation.Size = new System.Drawing.Size(235, 25);
            this.txtOrganisation.TabIndex = 2;
            this.txtOrganisation.Enter += new System.EventHandler(this.MouseFoucsEnter);
            this.txtOrganisation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            this.txtOrganisation.Leave += new System.EventHandler(this.MouseFoucsLeave);
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMobileNo.BackColor = System.Drawing.Color.White;
            this.txtMobileNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.Location = new System.Drawing.Point(138, 158);
            this.txtMobileNo.MaxLength = 43;
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(235, 25);
            this.txtMobileNo.TabIndex = 3;
            this.txtMobileNo.Enter += new System.EventHandler(this.MouseFoucsEnter);
            this.txtMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobileNo_KeyPress);
            this.txtMobileNo.Leave += new System.EventHandler(this.MouseFoucsLeave);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mobile No. :";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(138, 196);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(235, 25);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Enter += new System.EventHandler(this.MouseFoucsEnter);
            this.txtEmail.Leave += new System.EventHandler(this.MouseFoucsLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "E-Mail :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(20, 256);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Address :";
            // 
            // btnActivate
            // 
            this.btnActivate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActivate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivate.Enabled = false;
            this.btnActivate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActivate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivate.Location = new System.Drawing.Point(202, 497);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(80, 26);
            this.btnActivate.TabIndex = 11;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // txtKey
            // 
            this.txtKey.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtKey.BackColor = System.Drawing.Color.White;
            this.txtKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtKey.Enabled = false;
            this.txtKey.Font = new System.Drawing.Font("Cambria", 11.25F);
            this.txtKey.Location = new System.Drawing.Point(44, 461);
            this.txtKey.MaxLength = 50;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(366, 25);
            this.txtKey.TabIndex = 10;
            this.txtKey.Enter += new System.EventHandler(this.MouseFoucsEnter);
            this.txtKey.Leave += new System.EventHandler(this.MouseFoucsLeave);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 316);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 17);
            this.label7.TabIndex = 17;
            this.label7.Text = "Expiry Date :";
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpExpiryDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiryDate.Location = new System.Drawing.Point(138, 316);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(100, 25);
            this.dtpExpiryDate.TabIndex = 6;
            // 
            // Istrial
            // 
            this.Istrial.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Istrial.AutoSize = true;
            this.Istrial.BackColor = System.Drawing.Color.Transparent;
            this.Istrial.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Istrial.Location = new System.Drawing.Point(272, 320);
            this.Istrial.Name = "Istrial";
            this.Istrial.Size = new System.Drawing.Size(101, 21);
            this.Istrial.TabIndex = 7;
            this.Istrial.Text = "Trail Version";
            this.Istrial.UseVisualStyleBackColor = false;
            // 
            // txtAddress
            // 
            this.txtAddress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(138, 234);
            this.txtAddress.MaxLength = 1000;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(235, 65);
            this.txtAddress.TabIndex = 5;
            this.txtAddress.Text = "";
            this.txtAddress.Enter += new System.EventHandler(this.MouseFoucsEnter);
            this.txtAddress.Leave += new System.EventHandler(this.MouseFoucsLeave);
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.BackColor = System.Drawing.Color.Transparent;
            this.lblError.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(376, 54);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(15, 17);
            this.lblError.TabIndex = 18;
            this.lblError.Text = "*";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(376, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(15, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(376, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(376, 158);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(15, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(376, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 17);
            this.label11.TabIndex = 22;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(376, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(15, 17);
            this.label12.TabIndex = 23;
            this.label12.Text = "*";
            // 
            // label13
            // 
            this.label13.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(89, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(290, 19);
            this.label13.TabIndex = 24;
            this.label13.Text = "Fill the Details for Activating your Product";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.checkBox1.Location = new System.Drawing.Point(172, 432);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(117, 21);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.Text = "Is Already Key";
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // frmCustomerRegister
            // 
            this.AcceptButton = this.btnRegister;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(456, 532);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.Istrial);
            this.Controls.Add(this.dtpExpiryDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.txtOrganisation);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.txtEncKey);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmCustomerRegister";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 5;
            this.Text = "Customer Register";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CustomerRegister_FormClosing);
            this.Load += new System.EventHandler(this.CustomerRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEncKey;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOrganisation;
        private System.Windows.Forms.TextBox txtMobileNo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnActivate;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpExpiryDate;
        private System.Windows.Forms.CheckBox Istrial;
        private System.Windows.Forms.RichTextBox txtAddress;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

