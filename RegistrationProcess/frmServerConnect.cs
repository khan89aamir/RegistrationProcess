using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using CoreApp;
using System.IO;
using System.Data.Sql;
using System.Reflection;
using System.Threading;

namespace RegistrationProcess
{
    public partial class frmServerConnect : Form
    {

        Image B_Leave = RegistrationProcess.Properties.Resources.b_click;
        Image B_Enter = RegistrationProcess.Properties.Resources.b_on;

        clsConnection_DAL ObjDAL;
        clsUtility ObjUtil = new clsUtility();

        String strRDatabseName = String.Empty;
        String strRestorePath = String.Empty;
        String path1 = String.Empty;
        public String ClientDBName = String.Empty;
        public String exeName = String.Empty; //storing current exe file name so when registration window is closed the automatic current program will open.
        Thread ThrRestore;

        public delegate void dCloseLoading();
        //SqlConnection dataCon;
        Loading ObjLoading = new Loading();

        public frmServerConnect()
        {
            CoreApp.clsCommon.ShowErrorWindow = false;
            InitializeComponent();
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            ObjUtil.SetTextHighlightColor(txt);
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            TextBox txt = (TextBox)sender;
            ObjUtil.SetTextHighlightColor(txt, Color.White);
        }

        private void cboAuthenticationType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (cboAuthenticationType.SelectedIndex == 0)
            {
                clsDMCommon.ObjCon.ConnectionString = "Server=" + clsDMCommon.strServerName + ";Database=" + ClientDBName + ";uid=" + clsDMCommon.strUserID 
                    + ";pwd= " + clsDMCommon.strUserPassword + ";" +"Max Pool Size = 5004;Pooling=True";

                clsConnection_DAL ObjDAL = new clsConnection_DAL();
                ObjDAL.SetConnectionString(clsDMCommon.ObjCon.ConnectionString);
                if (ObjDAL.IsDatabaseExist(ClientDBName))
                {
                    if (!System.IO.Directory.Exists("AppConfig"))
                    {
                        System.IO.Directory.CreateDirectory("AppConfig");
                        File.WriteAllText("AppConfig\\ServerConfig.sc", ObjUtil.Encrypt(clsDMCommon.ObjCon.ConnectionString, true));
                    }
                    clsUtility.ShowInfoMessage("Database is already exist.\n please select client", clsUtility.strProjectTitle);
                    IsConnect = false;
                }
                else
                {
                    grpDBRestore.Enabled = true;
                    txtDabasePath.Focus();
                }
            }
            else if (cboAuthenticationType.SelectedIndex == 1)
            {
                grpDBRestore.Enabled = false;
                ConnectToDB(clsDMCommon.strServerName, clsDMCommon.strUserID, clsDMCommon.strUserPassword, ClientDBName);

                String conn = "Server=" + clsDMCommon.strServerName + ";Database=" + ClientDBName + ";uid=" + clsDMCommon.strUserID 
                    + ";pwd= " + clsDMCommon.strUserPassword + ";" +"Max Pool Size = 5004;Pooling=True";
                String EncrConn = ObjUtil.Encrypt(conn, true);
                if(!System.IO.Directory.Exists("AppConfig"))
                {
                    System.IO.Directory.CreateDirectory("AppConfig");
                    File.WriteAllText("AppConfig\\ServerConfig.sc", EncrConn);
                }
                
                ObjDAL = new clsConnection_DAL(true);
                DataTable dt = ObjDAL.GetDataCol(ClientDBName + ".dbo.RegistrationDetails", "[ID]", "PcName = '"+ Environment.MachineName+"'", null);
                if (dt == null || dt.Rows.Count == 0)
                {
                    InsertClientRegistration();
                }
                else
                {
                    clsUtility.ShowInfoMessage("Client is already Registered.", clsUtility.strProjectTitle);
                    Application.Exit();
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void InsertClientRegistration()
        {
            //clsConnection_DAL ObjDAL = new clsConnection_DAL(true);
            DataTable dt = ObjDAL.GetDataCol(ClientDBName + ".dbo.RegistrationDetails", "[SoftKey],[ExpiryDate],[StatusDate]"
                , "[IsServer] = 1 AND [IsKeyEnter] = 1", null);
            if (ObjUtil.ValidateTable(dt))
            {
                ObjDAL.SetColumnData("PcName", SqlDbType.NVarChar, Environment.MachineName);
                ObjDAL.SetColumnData("StatusDate", SqlDbType.VarChar, dt.Rows[0]["StatusDate"].ToString());
                ObjDAL.SetColumnData("SoftKey", SqlDbType.VarChar, dt.Rows[0]["SoftKey"].ToString());
                ObjDAL.SetColumnData("IsTrail", SqlDbType.Bit, 0);
                ObjDAL.SetColumnData("RegDate", SqlDbType.Date, DateTime.Now);
                ObjDAL.SetColumnData("ExpiryDate", SqlDbType.VarChar, dt.Rows[0]["ExpiryDate"].ToString());
                ObjDAL.SetColumnData("IsKeyEnter", SqlDbType.Bit, 1);

                if (ObjDAL.InsertData(ClientDBName + ".dbo.RegistrationDetails", true) > 0)
                {
                    ObjDAL.ResetData();
                    clsUtility.ShowInfoMessage("Client Registration is successfully", clsUtility.strProjectTitle);
                    //System.Diagnostics.Process.Start(exeName + ".exe");
                    Application.Exit();
                }
            }
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtServerName.Clear();
            txtUserID.Clear();
            txtPassword.Clear();
            txtServerName.Focus();

            btnConnect.Enabled=true;
        }

        private void ConnectToDB(string strServer, string userID, string strPassword)
        {
            try
            {
                if (clsDMCommon.ObjCon.State == ConnectionState.Open)
                {
                    clsDMCommon.ObjCon.Close();
                }
                clsDMCommon.ObjCon.ConnectionString = "Server=" + strServer + ";Database=master;uid=" + userID + ";pwd= " + strPassword + ";" +
                    "Max Pool Size = 5004;Pooling=True";
                if (clsDMCommon.ObjCon.State == ConnectionState.Closed || clsDMCommon.ObjCon.State == ConnectionState.Broken)
                {
                    clsDMCommon.ObjCon.Open();
                    clsDMCommon.ObjCon.Close();
                    IsConnect = true;
                    groupBox1.Enabled = true;
                    btnConnect.Enabled = false;
                }
            }
            catch (Exception ex)
            {
                IsConnect = false;
                clsUtility.ShowInfoMessage(ex.Message, clsUtility.strProjectTitle);
            }
        }
        private void ConnectToDB(string strServer, string userID, string strPassword, string strDBName)
        {
            IsConnect = false;
            try
            {
                if (clsDMCommon.ObjCon.State == ConnectionState.Open)
                {
                    clsDMCommon.ObjCon.Close();
                }
                clsDMCommon.ObjCon.ConnectionString = "Server=" + strServer + ";Database=" + strDBName + ";uid=" + userID + ";pwd= " + strPassword + ";" +
                    "Max Pool Size = 5004;Pooling=True";
                if (clsDMCommon.ObjCon.State == ConnectionState.Closed || clsDMCommon.ObjCon.State == ConnectionState.Broken)
                {
                    clsDMCommon.ObjCon.Open();
                    clsDMCommon.ObjCon.Close();
                    IsConnect = true;
                }
            }
            catch (Exception ex)
            {
                IsConnect = false;
                clsUtility.ShowInfoMessage("First select server to restore database.", clsUtility.strProjectTitle);
            }
        }
        bool IsConnect = false;
        private void btnConnect_Click(object sender, EventArgs e)
        {
            if (ValidateServerConenct())
            {
                this.Cursor = Cursors.WaitCursor;

                ConnectToDB(txtServerName.Text, txtUserID.Text, txtPassword.Text);
                clsDMCommon.strUserID = txtUserID.Text;
                clsDMCommon.strUserPassword = txtPassword.Text;
                clsDMCommon.strServerName = txtServerName.Text;
                clsDMCommon.IsConnectAgain = true;

                this.Cursor = Cursors.Default;
            }
        }
        private bool ValidateServerConenct()
        {
            if (ObjUtil.IsControlTextEmpty(txtServerName))
            {
                clsUtility.ShowErrorMessage("Please Enter Server Name.", clsUtility.strProjectTitle);
                txtServerName.Focus();
                return false;
            }

            // if server auth is selected then check username and password.
            else if (ObjUtil.IsControlTextEmpty(txtUserID))
            {
                clsUtility.ShowErrorMessage("Please Enter User ID.", clsUtility.strProjectTitle);
                txtUserID.Focus();
                return false;
            }

            else if (ObjUtil.IsControlTextEmpty(txtPassword))
            {
                clsUtility.ShowErrorMessage("Please Enter Password.", clsUtility.strProjectTitle);
                txtPassword.Focus();
                return false;
            }
            return true;
        }

        private void frmServerConnect_Load(object sender, EventArgs e)
        {
            btnConnect.BackgroundImage = B_Leave;
            btnClear.BackgroundImage = B_Leave;
            btnBrowse.BackgroundImage = B_Leave;
            btnRestore.BackgroundImage = B_Leave;
        }

        private void frmServerConnect_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!IsConnect)
            {
                clsDMCommon.IsDirectClose = true;
                Application.Exit();
            }
        }

        private void LoadConnection()
        {
            CloseLoading();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog Obj = new OpenFileDialog();
            Obj.Filter = "Database Backup File (*.bak)|*.bak";
            DialogResult d = Obj.ShowDialog();
            if (d == DialogResult.OK)
            {
                strRestorePath = Obj.FileName;
                FileInfo objfile = new FileInfo(strRestorePath);
                strRDatabseName = Path.GetFileNameWithoutExtension(strRestorePath);
                btnRestore.Enabled = true;
                txtDabasePath.Text = strRestorePath;
                txtDabasePath.ReadOnly = true;
            }
        }
        private void CloseLoading()
        {
            if (ObjLoading.InvokeRequired)
            {
                dCloseLoading d = new dCloseLoading(CloseLoading);
                this.Invoke(d, null);
            }
            else
            {
                ObjLoading.Close();
            }
        }
        private void RestoreDataBase()
        {
            try
            {
                clsDMCommon.ObjCon.ConnectionString = "Server=" + clsDMCommon.strServerName + ";Database=master;uid="
                    + clsDMCommon.strUserID + ";pwd= " + clsDMCommon.strUserPassword + ";" + "Max Pool Size = 5004;Pooling=True";
                if (clsDMCommon.ObjCon.State == ConnectionState.Closed)
                {
                    clsDMCommon.ObjCon.Open();
                }
                string sqlcmd = "RESTORE DATABASE " + strRDatabseName + " FROM DISK='" + strRestorePath + "' with replace";
                SqlCommand cmd = new SqlCommand(sqlcmd, clsDMCommon.ObjCon);
                cmd.ExecuteNonQuery();
                clsDMCommon.ObjCon.Close();
                CloseLoading();

                String conn = "Server=" + clsDMCommon.strServerName + ";Database=" + strRDatabseName + ";uid=" + clsDMCommon.strUserID 
                    + ";pwd= " + clsDMCommon.strUserPassword + ";" +"Max Pool Size = 5004;Pooling=True";
                String EncrConn = ObjUtil.Encrypt(conn, true);
                if (!Directory.Exists("AppConfig"))
                {
                    System.IO.Directory.CreateDirectory("AppConfig");
                    File.WriteAllText("AppConfig\\ServerConfig.sc", EncrConn);
                }

                clsDMCommon.ObjCon.ConnectionString = conn; //for loading connection string for frmCustomerRegister
                clsConnection_DAL ObjDAL = new clsConnection_DAL(true);
                ObjDAL.SetColumnData("PcName", SqlDbType.NVarChar, Environment.MachineName);
                ObjDAL.SetColumnData("StatusDate", SqlDbType.VarChar, ObjUtil.Encrypt(DateTime.Now.ToString("yyyy/MM/dd"), true));
                ObjDAL.SetColumnData("IsTrail", SqlDbType.Bit, 1);
                ObjDAL.SetColumnData("RegDate", SqlDbType.Date, DateTime.Now);
                ObjDAL.SetColumnData("ExpiryDate", SqlDbType.VarChar, ObjUtil.Encrypt(DateTime.Now.AddDays(7).ToString("yyyy/MM/dd"), true));
                ObjDAL.SetColumnData("IsKeyEnter", SqlDbType.Bit, 0);
                ObjDAL.SetColumnData("IsServer", SqlDbType.Bit, 1);

                if (ObjDAL.InsertData(strRDatabseName + ".dbo.RegistrationDetails", true) > 0)
                {
                    clsUtility.ShowInfoMessage("RESTORE DATABASE successfully.", clsUtility.strProjectTitle);
                }
            }
            catch (Exception ex)
            {
                clsDMCommon.ObjCon.Close();
                CloseLoading();
                clsUtility.ShowErrorMessage(ex.ToString(), clsUtility.strProjectTitle);
            }
            //RESTORE DATABASE database_name FROM backup_device WITH RECOVERY
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            ThrRestore = new Thread(new ThreadStart(RestoreDataBase));
            ThrRestore.SetApartmentState(ApartmentState.MTA);
            ThrRestore.Start();
            ObjLoading.label1.Text = "Restoring Please Wait...";
            ObjLoading.BringToFront();
            ObjLoading.ShowDialog();

            frmCustomerRegister reg = new RegistrationProcess.frmCustomerRegister();
            //reg.exeName = System.Diagnostics.Process.GetCurrentProcess().ProcessName;
            this.Close();
            reg.BringToFront();
            reg.Show();
        }

        private void btnConnect_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Enter;
        }

        private void btnConnect_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Leave;
        }
    }
}
