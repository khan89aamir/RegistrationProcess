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
            this.lblServerName = new System.Windows.Forms.Label();
            this.txtPassword = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txtUserID = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.lblUserID = new System.Windows.Forms.Label();
            this.btnConnect = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnClear = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtServerName = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.grpKrytonHeader = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.groupBox1 = new gGlowBox.gGlowGroupBox();
            this.cboAuthenticationType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.kgrpDBRestore = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.grpDBRestore = new gGlowBox.gGlowGroupBox();
            this.btnRestore = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.lblRestoreDatabase = new System.Windows.Forms.Label();
            this.btnBrowse = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtDabasePath = new ComponentFactory.Krypton.Toolkit.KryptonTextBox();
            this.kgrpbackupDB = new ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup();
            this.gGlowGroupBox1 = new gGlowBox.gGlowGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader.Panel)).BeginInit();
            this.grpKrytonHeader.Panel.SuspendLayout();
            this.grpKrytonHeader.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cboAuthenticationType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpDBRestore)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpDBRestore.Panel)).BeginInit();
            this.kgrpDBRestore.Panel.SuspendLayout();
            this.kgrpDBRestore.SuspendLayout();
            this.grpDBRestore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpbackupDB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpbackupDB.Panel)).BeginInit();
            this.kgrpbackupDB.Panel.SuspendLayout();
            this.kgrpbackupDB.SuspendLayout();
            this.gGlowGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblServerName
            // 
            this.lblServerName.AutoSize = true;
            this.lblServerName.BackColor = System.Drawing.Color.Transparent;
            this.lblServerName.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblServerName.Location = new System.Drawing.Point(12, 14);
            this.lblServerName.Name = "lblServerName";
            this.lblServerName.Size = new System.Drawing.Size(97, 19);
            this.lblServerName.TabIndex = 0;
            this.lblServerName.Text = "Server Name :";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(112, 80);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '●';
            this.txtPassword.Size = new System.Drawing.Size(197, 29);
            this.txtPassword.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtPassword.StateCommon.Border.Rounding = 10;
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblPassword.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblPassword.Location = new System.Drawing.Point(12, 85);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 19);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password :";
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(112, 45);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(197, 29);
            this.txtUserID.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtUserID.StateCommon.Border.Rounding = 10;
            this.txtUserID.TabIndex = 1;
            // 
            // lblUserID
            // 
            this.lblUserID.AutoSize = true;
            this.lblUserID.BackColor = System.Drawing.Color.Transparent;
            this.lblUserID.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblUserID.Location = new System.Drawing.Point(12, 49);
            this.lblUserID.Name = "lblUserID";
            this.lblUserID.Size = new System.Drawing.Size(65, 19);
            this.lblUserID.TabIndex = 5;
            this.lblUserID.Text = "User ID :";
            // 
            // btnConnect
            // 
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnect.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gGlowGroupBox1.SetEffectType(this.btnConnect, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.btnConnect.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConnect.Location = new System.Drawing.Point(112, 116);
            this.btnConnect.Name = "btnConnect";
            this.gGlowGroupBox1.SetsGlowColor(this.btnConnect, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("btnConnect.sGlowColor"))));
            this.btnConnect.Size = new System.Drawing.Size(90, 30);
            this.btnConnect.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnConnect.StateCommon.Border.Rounding = 12;
            this.btnConnect.TabIndex = 6;
            this.btnConnect.Values.Text = "Connect";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.gGlowGroupBox1.SetEffectType(this.btnClear, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.btnClear.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(219, 116);
            this.btnClear.Name = "btnClear";
            this.gGlowGroupBox1.SetsGlowColor(this.btnClear, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("btnClear.sGlowColor"))));
            this.btnClear.Size = new System.Drawing.Size(90, 30);
            this.btnClear.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnClear.StateCommon.Border.Rounding = 12;
            this.btnClear.TabIndex = 7;
            this.btnClear.Values.Text = "Clear";
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // txtServerName
            // 
            this.txtServerName.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtServerName.Location = new System.Drawing.Point(112, 10);
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(197, 29);
            this.txtServerName.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtServerName.StateCommon.Border.Rounding = 10;
            this.txtServerName.TabIndex = 0;
            // 
            // grpKrytonHeader
            // 
            this.grpKrytonHeader.HeaderVisibleSecondary = false;
            this.grpKrytonHeader.Location = new System.Drawing.Point(21, 210);
            this.grpKrytonHeader.Name = "grpKrytonHeader";
            this.grpKrytonHeader.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            // 
            // grpKrytonHeader.Panel
            // 
            this.grpKrytonHeader.Panel.Controls.Add(this.groupBox1);
            this.grpKrytonHeader.Size = new System.Drawing.Size(332, 86);
            this.grpKrytonHeader.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpKrytonHeader.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.grpKrytonHeader.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpKrytonHeader.StateCommon.Border.Rounding = 10;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Back.Image = global::RegistrationProcess.Properties.Resources.titlebg_green;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Border.Color1 = System.Drawing.Color.White;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Border.Rounding = 10;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.grpKrytonHeader.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKrytonHeader.TabIndex = 331;
            this.grpKrytonHeader.ValuesPrimary.Heading = "Server Type";
            this.grpKrytonHeader.ValuesPrimary.Image = null;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.cboAuthenticationType);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Enabled = false;
            this.groupBox1.GlowAmount = 22;
            this.groupBox1.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.groupBox1.GlowFeather = 60;
            this.groupBox1.GlowOn = true;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(324, 52);
            this.groupBox1.TabIndex = 287;
            // 
            // cboAuthenticationType
            // 
            this.cboAuthenticationType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAuthenticationType.DropDownWidth = 200;
            this.cboAuthenticationType.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.cboAuthenticationType.FormattingEnabled = true;
            this.cboAuthenticationType.Items.AddRange(new object[] {
            "Server",
            "Client"});
            this.cboAuthenticationType.Location = new System.Drawing.Point(42, 9);
            this.cboAuthenticationType.Name = "cboAuthenticationType";
            this.cboAuthenticationType.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.cboAuthenticationType.Size = new System.Drawing.Size(211, 27);
            this.cboAuthenticationType.StateCommon.ComboBox.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.cboAuthenticationType.StateCommon.ComboBox.Border.Rounding = 10;
            this.cboAuthenticationType.TabIndex = 2;
            this.cboAuthenticationType.SelectionChangeCommitted += new System.EventHandler(this.cboAuthenticationType_SelectionChangeCommitted);
            // 
            // kgrpDBRestore
            // 
            this.kgrpDBRestore.HeaderVisibleSecondary = false;
            this.kgrpDBRestore.Location = new System.Drawing.Point(21, 302);
            this.kgrpDBRestore.Name = "kgrpDBRestore";
            // 
            // kgrpDBRestore.Panel
            // 
            this.kgrpDBRestore.Panel.Controls.Add(this.grpDBRestore);
            this.kgrpDBRestore.Size = new System.Drawing.Size(332, 147);
            this.kgrpDBRestore.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kgrpDBRestore.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kgrpDBRestore.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kgrpDBRestore.StateCommon.Border.Rounding = 10;
            this.kgrpDBRestore.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kgrpDBRestore.StateCommon.HeaderPrimary.Back.Image = ((System.Drawing.Image)(resources.GetObject("kgrpDBRestore.StateCommon.HeaderPrimary.Back.Image")));
            this.kgrpDBRestore.StateCommon.HeaderPrimary.Border.Color1 = System.Drawing.Color.White;
            this.kgrpDBRestore.StateCommon.HeaderPrimary.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kgrpDBRestore.StateCommon.HeaderPrimary.Border.Rounding = 10;
            this.kgrpDBRestore.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgrpDBRestore.StateCommon.HeaderPrimary.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kgrpDBRestore.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgrpDBRestore.TabIndex = 332;
            this.kgrpDBRestore.ValuesPrimary.Heading = "Restore Database";
            this.kgrpDBRestore.ValuesPrimary.Image = null;
            // 
            // grpDBRestore
            // 
            this.grpDBRestore.BackColor = System.Drawing.Color.Transparent;
            this.grpDBRestore.Controls.Add(this.btnRestore);
            this.grpDBRestore.Controls.Add(this.lblRestoreDatabase);
            this.grpDBRestore.Controls.Add(this.btnBrowse);
            this.grpDBRestore.Controls.Add(this.txtDabasePath);
            this.grpDBRestore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpDBRestore.Enabled = false;
            this.grpDBRestore.GlowAmount = 22;
            this.grpDBRestore.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.grpDBRestore.GlowFeather = 60;
            this.grpDBRestore.GlowOn = true;
            this.grpDBRestore.Location = new System.Drawing.Point(0, 0);
            this.grpDBRestore.Name = "grpDBRestore";
            this.grpDBRestore.Size = new System.Drawing.Size(324, 113);
            this.grpDBRestore.TabIndex = 287;
            // 
            // btnRestore
            // 
            this.btnRestore.AutoSize = true;
            this.btnRestore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grpDBRestore.SetEffectType(this.btnRestore, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.btnRestore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnRestore.Location = new System.Drawing.Point(229, 79);
            this.btnRestore.Name = "btnRestore";
            this.btnRestore.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnRestore.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.grpDBRestore.SetsGlowColor(this.btnRestore, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("btnRestore.sGlowColor"))));
            this.btnRestore.Size = new System.Drawing.Size(90, 31);
            this.btnRestore.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnRestore.StateCommon.Border.Rounding = 12;
            this.btnRestore.TabIndex = 311;
            this.btnRestore.Values.Text = "Restore";
            this.btnRestore.Click += new System.EventHandler(this.btnRestore_Click);
            // 
            // lblRestoreDatabase
            // 
            this.lblRestoreDatabase.AutoSize = true;
            this.lblRestoreDatabase.BackColor = System.Drawing.Color.Transparent;
            this.lblRestoreDatabase.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.lblRestoreDatabase.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblRestoreDatabase.Location = new System.Drawing.Point(9, 16);
            this.lblRestoreDatabase.Name = "lblRestoreDatabase";
            this.lblRestoreDatabase.Size = new System.Drawing.Size(195, 19);
            this.lblRestoreDatabase.TabIndex = 2;
            this.lblRestoreDatabase.Text = "Browse Database To Restore :";
            // 
            // btnBrowse
            // 
            this.btnBrowse.AutoSize = true;
            this.btnBrowse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.grpDBRestore.SetEffectType(this.btnBrowse, gGlowBox.gGlowGroupBox.eEffectType.Glow);
            this.btnBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnBrowse.Location = new System.Drawing.Point(229, 9);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.OverrideFocus.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.btnBrowse.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2007Blue;
            this.grpDBRestore.SetsGlowColor(this.btnBrowse, ((gGlowBox.gGlowGroupBox.SerialColor)(resources.GetObject("btnBrowse.sGlowColor"))));
            this.btnBrowse.Size = new System.Drawing.Size(90, 31);
            this.btnBrowse.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.btnBrowse.StateCommon.Border.Rounding = 12;
            this.btnBrowse.TabIndex = 310;
            this.btnBrowse.Values.Text = "Browse";
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // txtDabasePath
            // 
            this.txtDabasePath.BackColor = System.Drawing.Color.White;
            this.txtDabasePath.Font = new System.Drawing.Font("Times New Roman", 12F);
            this.txtDabasePath.Location = new System.Drawing.Point(4, 46);
            this.txtDabasePath.Name = "txtDabasePath";
            this.txtDabasePath.ReadOnly = true;
            this.txtDabasePath.Size = new System.Drawing.Size(319, 29);
            this.txtDabasePath.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.txtDabasePath.StateCommon.Border.Rounding = 10;
            this.txtDabasePath.TabIndex = 5;
            // 
            // kgrpbackupDB
            // 
            this.kgrpbackupDB.HeaderVisibleSecondary = false;
            this.kgrpbackupDB.Location = new System.Drawing.Point(21, 12);
            this.kgrpbackupDB.Name = "kgrpbackupDB";
            this.kgrpbackupDB.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            // 
            // kgrpbackupDB.Panel
            // 
            this.kgrpbackupDB.Panel.Controls.Add(this.gGlowGroupBox1);
            this.kgrpbackupDB.Size = new System.Drawing.Size(332, 184);
            this.kgrpbackupDB.StateCommon.Back.Color1 = System.Drawing.Color.Transparent;
            this.kgrpbackupDB.StateCommon.Border.Color1 = System.Drawing.Color.White;
            this.kgrpbackupDB.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kgrpbackupDB.StateCommon.Border.Rounding = 10;
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Back.Color1 = System.Drawing.Color.Transparent;
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Back.Image = global::RegistrationProcess.Properties.Resources.titlebg_green;
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Border.Rounding = 10;
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Content.LongText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Content.ShortText.Color1 = System.Drawing.Color.White;
            this.kgrpbackupDB.StateCommon.HeaderPrimary.Content.ShortText.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kgrpbackupDB.TabIndex = 333;
            this.kgrpbackupDB.ValuesPrimary.Heading = "Connect to Server";
            this.kgrpbackupDB.ValuesPrimary.Image = null;
            // 
            // gGlowGroupBox1
            // 
            this.gGlowGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.gGlowGroupBox1.Controls.Add(this.lblServerName);
            this.gGlowGroupBox1.Controls.Add(this.btnConnect);
            this.gGlowGroupBox1.Controls.Add(this.btnClear);
            this.gGlowGroupBox1.Controls.Add(this.txtPassword);
            this.gGlowGroupBox1.Controls.Add(this.lblUserID);
            this.gGlowGroupBox1.Controls.Add(this.txtServerName);
            this.gGlowGroupBox1.Controls.Add(this.txtUserID);
            this.gGlowGroupBox1.Controls.Add(this.lblPassword);
            this.gGlowGroupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gGlowGroupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.gGlowGroupBox1.GlowAmount = 22;
            this.gGlowGroupBox1.GlowColorDefault = System.Drawing.Color.FromArgb(((int)(((byte)(133)))), ((int)(((byte)(179)))), ((int)(((byte)(205)))));
            this.gGlowGroupBox1.GlowFeather = 60;
            this.gGlowGroupBox1.GlowOn = true;
            this.gGlowGroupBox1.Location = new System.Drawing.Point(0, 0);
            this.gGlowGroupBox1.Name = "gGlowGroupBox1";
            this.gGlowGroupBox1.Size = new System.Drawing.Size(324, 150);
            this.gGlowGroupBox1.TabIndex = 287;
            // 
            // frmServerConnect
            // 
            this.AcceptButton = this.btnConnect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::RegistrationProcess.Properties.Resources.back_green;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(378, 458);
            this.Controls.Add(this.kgrpbackupDB);
            this.Controls.Add(this.kgrpDBRestore);
            this.Controls.Add(this.grpKrytonHeader);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmServerConnect";
            this.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StateCommon.Border.DrawBorders = ((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders)((((ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Top | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Bottom) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Left) 
            | ComponentFactory.Krypton.Toolkit.PaletteDrawBorders.Right)));
            this.StateCommon.Border.Rounding = 5;
            this.Text = "Connect to Server";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmServerConnect_FormClosing);
            this.Load += new System.EventHandler(this.frmServerConnect_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader.Panel)).EndInit();
            this.grpKrytonHeader.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grpKrytonHeader)).EndInit();
            this.grpKrytonHeader.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cboAuthenticationType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpDBRestore.Panel)).EndInit();
            this.kgrpDBRestore.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgrpDBRestore)).EndInit();
            this.kgrpDBRestore.ResumeLayout(false);
            this.grpDBRestore.ResumeLayout(false);
            this.grpDBRestore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kgrpbackupDB.Panel)).EndInit();
            this.kgrpbackupDB.Panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kgrpbackupDB)).EndInit();
            this.kgrpbackupDB.ResumeLayout(false);
            this.gGlowGroupBox1.ResumeLayout(false);
            this.gGlowGroupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblServerName;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtPassword;
        private System.Windows.Forms.Label lblPassword;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtUserID;
        private System.Windows.Forms.Label lblUserID;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnConnect;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnClear;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtServerName;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup grpKrytonHeader;
        private gGlowBox.gGlowGroupBox groupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox cboAuthenticationType;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kgrpDBRestore;
        private gGlowBox.gGlowGroupBox grpDBRestore;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnRestore;
        private System.Windows.Forms.Label lblRestoreDatabase;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnBrowse;
        private ComponentFactory.Krypton.Toolkit.KryptonTextBox txtDabasePath;
        private gGlowBox.gGlowGroupBox gGlowGroupBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonHeaderGroup kgrpbackupDB;
    }
}