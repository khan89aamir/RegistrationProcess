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
            this.txtEncKey = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.btnRegister = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.txtCustomerName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtProductName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblOrg = new System.Windows.Forms.Label();
            this.txtOrganisation = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.txtMobileNo = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblMobileNo = new System.Windows.Forms.Label();
            this.txtEmail = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.btnActivate = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtKey = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblExpiry = new System.Windows.Forms.Label();
            this.dtpExpiryDate = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.Istrial = new System.Windows.Forms.CheckBox();
            this.txtAddress = new ComponentFactory.Krypton.Toolkit.KryptonRichTextBox();
            this.lblError1 = new System.Windows.Forms.Label();
            this.lblError2 = new System.Windows.Forms.Label();
            this.lblError3 = new System.Windows.Forms.Label();
            this.lblError4 = new System.Windows.Forms.Label();
            this.lblError5 = new System.Windows.Forms.Label();
            this.lblError6 = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
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
            this.txtEncKey.Size = new System.Drawing.Size(366, 29);
            this.txtEncKey.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEncKey.StateCommon.Border.Rounding = 10;
            this.txtEncKey.TabIndex = 9;
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegister.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegister.Location = new System.Drawing.Point(199, 357);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(90, 30);
            this.btnRegister.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRegister.StateCommon.Border.Rounding = 12;
            this.btnRegister.TabIndex = 8;
            this.btnRegister.Values.Text = "Register";
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(20, 58);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(112, 17);
            this.lblCustomerName.TabIndex = 2;
            this.lblCustomerName.Text = "Customer Name :";
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
            this.txtCustomerName.Size = new System.Drawing.Size(235, 29);
            this.txtCustomerName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtCustomerName.StateCommon.Border.Rounding = 10;
            this.txtCustomerName.TabIndex = 0;
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            // 
            // txtProductName
            // 
            this.txtProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtProductName.BackColor = System.Drawing.Color.White;
            this.txtProductName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtProductName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(138, 90);
            this.txtProductName.MaxLength = 25;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(235, 29);
            this.txtProductName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtProductName.StateCommon.Border.Rounding = 10;
            this.txtProductName.TabIndex = 1;
            this.txtProductName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            // 
            // lblProductName
            // 
            this.lblProductName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblProductName.AutoSize = true;
            this.lblProductName.BackColor = System.Drawing.Color.Transparent;
            this.lblProductName.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(20, 96);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(101, 17);
            this.lblProductName.TabIndex = 4;
            this.lblProductName.Text = "Product Name :";
            // 
            // lblOrg
            // 
            this.lblOrg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblOrg.AutoSize = true;
            this.lblOrg.BackColor = System.Drawing.Color.Transparent;
            this.lblOrg.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrg.Location = new System.Drawing.Point(20, 132);
            this.lblOrg.Name = "lblOrg";
            this.lblOrg.Size = new System.Drawing.Size(89, 17);
            this.lblOrg.TabIndex = 6;
            this.lblOrg.Text = "Organisation :";
            // 
            // txtOrganisation
            // 
            this.txtOrganisation.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtOrganisation.BackColor = System.Drawing.Color.White;
            this.txtOrganisation.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtOrganisation.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOrganisation.Location = new System.Drawing.Point(138, 126);
            this.txtOrganisation.MaxLength = 25;
            this.txtOrganisation.Name = "txtOrganisation";
            this.txtOrganisation.Size = new System.Drawing.Size(235, 29);
            this.txtOrganisation.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtOrganisation.StateCommon.Border.Rounding = 10;
            this.txtOrganisation.TabIndex = 2;
            this.txtOrganisation.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            // 
            // txtMobileNo
            // 
            this.txtMobileNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtMobileNo.BackColor = System.Drawing.Color.White;
            this.txtMobileNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileNo.Location = new System.Drawing.Point(138, 162);
            this.txtMobileNo.MaxLength = 43;
            this.txtMobileNo.Name = "txtMobileNo";
            this.txtMobileNo.Size = new System.Drawing.Size(235, 29);
            this.txtMobileNo.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtMobileNo.StateCommon.Border.Rounding = 10;
            this.txtMobileNo.TabIndex = 3;
            this.txtMobileNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMobileNo_KeyPress);
            // 
            // lblMobileNo
            // 
            this.lblMobileNo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMobileNo.AutoSize = true;
            this.lblMobileNo.BackColor = System.Drawing.Color.Transparent;
            this.lblMobileNo.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMobileNo.Location = new System.Drawing.Point(20, 168);
            this.lblMobileNo.Name = "lblMobileNo";
            this.lblMobileNo.Size = new System.Drawing.Size(81, 17);
            this.lblMobileNo.TabIndex = 9;
            this.lblMobileNo.Text = "Mobile No. :";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(138, 198);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(235, 29);
            this.txtEmail.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtEmail.StateCommon.Border.Rounding = 10;
            this.txtEmail.TabIndex = 4;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(20, 204);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(55, 17);
            this.lblEmail.TabIndex = 11;
            this.lblEmail.Text = "E-Mail :";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.BackColor = System.Drawing.Color.Transparent;
            this.lblAddress.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(20, 256);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(64, 17);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Address :";
            // 
            // btnActivate
            // 
            this.btnActivate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnActivate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnActivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActivate.Enabled = false;
            this.btnActivate.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActivate.Location = new System.Drawing.Point(202, 497);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(90, 30);
            this.btnActivate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnActivate.StateCommon.Border.Rounding = 12;
            this.btnActivate.TabIndex = 11;
            this.btnActivate.Values.Text = "Activate";
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
            this.txtKey.Size = new System.Drawing.Size(366, 29);
            this.txtKey.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtKey.StateCommon.Border.Rounding = 10;
            this.txtKey.TabIndex = 10;
            // 
            // lblExpiry
            // 
            this.lblExpiry.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblExpiry.AutoSize = true;
            this.lblExpiry.BackColor = System.Drawing.Color.Transparent;
            this.lblExpiry.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiry.Location = new System.Drawing.Point(20, 321);
            this.lblExpiry.Name = "lblExpiry";
            this.lblExpiry.Size = new System.Drawing.Size(86, 17);
            this.lblExpiry.TabIndex = 17;
            this.lblExpiry.Text = "Expiry Date :";
            // 
            // dtpExpiryDate
            // 
            this.dtpExpiryDate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtpExpiryDate.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpExpiryDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpiryDate.Location = new System.Drawing.Point(138, 316);
            this.dtpExpiryDate.Name = "dtpExpiryDate";
            this.dtpExpiryDate.Size = new System.Drawing.Size(100, 27);
            this.dtpExpiryDate.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.dtpExpiryDate.StateCommon.Border.Rounding = 10;
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
            this.txtAddress.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtAddress.StateCommon.Border.Rounding = 10;
            this.txtAddress.TabIndex = 5;
            this.txtAddress.Text = "";
            // 
            // lblError1
            // 
            this.lblError1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError1.AutoSize = true;
            this.lblError1.BackColor = System.Drawing.Color.Transparent;
            this.lblError1.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError1.ForeColor = System.Drawing.Color.Red;
            this.lblError1.Location = new System.Drawing.Point(376, 54);
            this.lblError1.Name = "lblError1";
            this.lblError1.Size = new System.Drawing.Size(15, 17);
            this.lblError1.TabIndex = 18;
            this.lblError1.Text = "*";
            // 
            // lblError2
            // 
            this.lblError2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError2.AutoSize = true;
            this.lblError2.BackColor = System.Drawing.Color.Transparent;
            this.lblError2.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError2.ForeColor = System.Drawing.Color.Red;
            this.lblError2.Location = new System.Drawing.Point(376, 92);
            this.lblError2.Name = "lblError2";
            this.lblError2.Size = new System.Drawing.Size(15, 17);
            this.lblError2.TabIndex = 19;
            this.lblError2.Text = "*";
            // 
            // lblError3
            // 
            this.lblError3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError3.AutoSize = true;
            this.lblError3.BackColor = System.Drawing.Color.Transparent;
            this.lblError3.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError3.ForeColor = System.Drawing.Color.Red;
            this.lblError3.Location = new System.Drawing.Point(376, 125);
            this.lblError3.Name = "lblError3";
            this.lblError3.Size = new System.Drawing.Size(15, 17);
            this.lblError3.TabIndex = 20;
            this.lblError3.Text = "*";
            // 
            // lblError4
            // 
            this.lblError4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError4.AutoSize = true;
            this.lblError4.BackColor = System.Drawing.Color.Transparent;
            this.lblError4.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError4.ForeColor = System.Drawing.Color.Red;
            this.lblError4.Location = new System.Drawing.Point(376, 158);
            this.lblError4.Name = "lblError4";
            this.lblError4.Size = new System.Drawing.Size(15, 17);
            this.lblError4.TabIndex = 21;
            this.lblError4.Text = "*";
            // 
            // lblError5
            // 
            this.lblError5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError5.AutoSize = true;
            this.lblError5.BackColor = System.Drawing.Color.Transparent;
            this.lblError5.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError5.ForeColor = System.Drawing.Color.Red;
            this.lblError5.Location = new System.Drawing.Point(376, 196);
            this.lblError5.Name = "lblError5";
            this.lblError5.Size = new System.Drawing.Size(15, 17);
            this.lblError5.TabIndex = 22;
            this.lblError5.Text = "*";
            // 
            // lblError6
            // 
            this.lblError6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError6.AutoSize = true;
            this.lblError6.BackColor = System.Drawing.Color.Transparent;
            this.lblError6.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError6.ForeColor = System.Drawing.Color.Red;
            this.lblError6.Location = new System.Drawing.Point(376, 234);
            this.lblError6.Name = "lblError6";
            this.lblError6.Size = new System.Drawing.Size(15, 17);
            this.lblError6.TabIndex = 23;
            this.lblError6.Text = "*";
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblTitle.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(89, 14);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(290, 19);
            this.lblTitle.TabIndex = 24;
            this.lblTitle.Text = "Fill the Details for Activating your Product";
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
            this.BackgroundImage = global::RegistrationProcess.Properties.Resources.back_green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(456, 532);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.lblError6);
            this.Controls.Add(this.lblError5);
            this.Controls.Add(this.lblError4);
            this.Controls.Add(this.lblError3);
            this.Controls.Add(this.lblError2);
            this.Controls.Add(this.lblError1);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.Istrial);
            this.Controls.Add(this.dtpExpiryDate);
            this.Controls.Add(this.lblExpiry);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.btnActivate);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblMobileNo);
            this.Controls.Add(this.txtMobileNo);
            this.Controls.Add(this.txtOrganisation);
            this.Controls.Add(this.lblOrg);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCustomerName);
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

        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEncKey;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRegister;
        private System.Windows.Forms.Label lblCustomerName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtCustomerName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtProductName;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblOrg;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtOrganisation;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtMobileNo;
        private System.Windows.Forms.Label lblMobileNo;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblAddress;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnActivate;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtKey;
        private System.Windows.Forms.Label lblExpiry;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker dtpExpiryDate;
        private System.Windows.Forms.CheckBox Istrial;
        private ComponentFactory.Krypton.Toolkit.KryptonRichTextBox txtAddress;
        private System.Windows.Forms.Label lblError1;
        private System.Windows.Forms.Label lblError2;
        private System.Windows.Forms.Label lblError3;
        private System.Windows.Forms.Label lblError4;
        private System.Windows.Forms.Label lblError5;
        private System.Windows.Forms.Label lblError6;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}