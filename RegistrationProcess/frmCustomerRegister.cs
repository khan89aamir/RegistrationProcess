using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Security.Cryptography;
using System.Security;
using CoreApp;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;

namespace RegistrationProcess
{
    public partial class frmCustomerRegister : Form
    {
        public frmCustomerRegister()
        {
            InitializeComponent();
        }
        public string exeName = string.Empty; //storing current exe file name so when registration window is closed the automatic current program will open.
        string DBName = string.Empty; //storing database name
        string strRealKey = string.Empty;
        string customerData = string.Empty;
        //string CustInfo = string.Empty; is used to paasing customer info for generating key
        bool b = false;  //for checking if internet is not on
        bool isexit = true;
        public delegate void dDatetimepicker();
        public delegate void dtxtEncrypt(string key);

        clsUtility Obj = new clsUtility();
        clsConnection_DAL ObjDAL = new clsConnection_DAL(true); //for connection
        clsUtility Objutil = new clsUtility(); //validating or encrypting or descrypting setgridproperty

        Image B_Leave = RegistrationProcess.Properties.Resources.b_click;
        Image B_Enter = RegistrationProcess.Properties.Resources.b_on;
        Image imgLoading = RegistrationProcess.Properties.Resources.animated;
        clsThreadTask ObjThread = new clsThreadTask();

        private void ValidatingExpDate()
        {
            DataTable dt = ObjDAL.GetData(DBName + ".dbo.RegistrationDetails", "[PcName]='" + Environment.MachineName + "' and [IsKeyEnter]=1", "RegistrationID");
            if (dt != null && dt.Rows.Count > 0)
            {
                dDatetimepicker dd = new dDatetimepicker(ValidatingExpDate);
                if (dtpExpiryDate.InvokeRequired)
                {
                    this.Invoke(dd, null);
                }
                else
                {
                    dtpExpiryDate.Value = Convert.ToDateTime(Objutil.Decrypt(dt.Rows[0]["ExpiryDate"].ToString(), true));
                    dtpExpiryDate.Enabled = false;
                }
            }
            else
            {
                dDatetimepicker dd = new dDatetimepicker(ValidatingExpDate);
                if (dtpExpiryDate.InvokeRequired)
                {
                    this.Invoke(dd, null);
                }
                else
                {
                    dtpExpiryDate.Enabled = true;
                    dtpExpiryDate.MinDate = DateTime.Now;
                    dtpExpiryDate.MaxDate = DateTime.Now.AddYears(1);
                }
            }
        }
        private void SetEncyrptText(string k)
        {
            dtxtEncrypt txt = new dtxtEncrypt(SetEncyrptText);
            if (txtEncKey.InvokeRequired)
            {
                this.Invoke(txt, new object[] { k });
            }
            else
            {
                txtEncKey.Text = k;
                txtEncKey.Enabled = true;
            }
        }
        private void LoadData()
        {
            ObjThread.ShowImageLoading(clsUtility.strProjectTitle, "Generating Key please Wait..", this, null);
            string s1 = CoreSys.clsRegKey.GenrateEncKey("KhanSoft", "13579");
            if (DBName.Length > 0)
            {
                ValidatingExpDate();
            }
            SetEncyrptText(s1);
            strRealKey = CoreSys.clsRegKey.DecryptKey(s1, "KhanSoft", "13579");
            //customerData = "\nDataBase Name : " + DBName + "\nEncrypted Key : " + strRealKey;
            DataSave();
            CreateFile();
            ObjThread.CloseImageLoadingDialog();
            //ObjThread.CloseLoadingDialog();
        }
        private void InsertComapnyMasterTable()
        {
            ObjDAL.SetColumnData("CompanyName", SqlDbType.NVarChar, txtOrganisation.Text.Trim());
            ObjDAL.SetColumnData("Address", SqlDbType.NVarChar, txtAddress.Text.Trim());
            ObjDAL.SetColumnData("MobileNo", SqlDbType.NVarChar, txtMobileNo.Text.Trim());
            ObjDAL.SetColumnData("EmailID", SqlDbType.NVarChar, txtEmail.Text.Trim());
            ObjDAL.InsertData(DBName + ".dbo.CompanyMaster", false);
            ObjDAL.ResetData();
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (Validation())
            {
                InsertComapnyMasterTable();
                LoadData();
                //Thread th = new Thread(new ThreadStart(LoadData));
                //th.SetApartmentState(ApartmentState.STA);
                //th.Start();

                customerData = "\nDataBase Name : " + DBName + "\n" +
                                  "Encrypted Key : " + strRealKey + "\n" +
                                  "Customer Name : " + txtCustomerName.Text.Trim() + "\n" +
                                  "Product Name : " + txtProductName.Text.Trim() + "\n" +
                                  "Organisation Name : " + txtOrganisation.Text.Trim() + "\n" +
                                  "Mobile Number : " + txtMobileNo.Text.Trim() + "\n" +
                                  "Email ID : " + txtEmail.Text.Trim() + "\n" +
                                  "Address : " + txtAddress.Text.Trim() + "\n" +
                                  "Expiry Date(DD/MM/YYYY) : " + dtpExpiryDate.Value.ToString("dd/MM/yyyy") + "\n" +
                                  "Is Trail : " + Istrial.Checked;

                string sub = "Request for a new product key.";
                string body = "Request for a new product key. from Machine : " + Environment.MachineName + " has requested for a new product key for \n" + customerData;

                SendEmail(sub, body);
                if (b)
                {
                    clsUtility.ShowInfoMessage("An E-Mail has been sent to the software developers for a Product Key.\nYou will receive your Product Key at your E-Mail Address", clsUtility.strProjectTitle);
                }
                else
                {
                    clsUtility.ShowInfoMessage("Unable to Send An E-Mail for Registration Key request.", clsUtility.strProjectTitle);
                }
                btnActivate.Enabled = true;
                txtKey.Enabled = true;
                txtKey.Focus();
            }
        }
        private void CreateFile()
        {
            if (System.IO.File.Exists("ServierConfig.DAT"))
            {
                System.IO.File.SetAttributes("ServierConfig.DAT", System.IO.FileAttributes.Normal);
            }
            System.IO.StreamWriter sw = new System.IO.StreamWriter("ServierConfig.DAT", false);
            sw.WriteLine(txtEncKey.Text);
            sw.Close();
            System.IO.File.SetAttributes("ServierConfig.DAT", System.IO.FileAttributes.Hidden);
        }
        private void SendEmail(string subject, string body)
        {
            //ObjThread.ShowImageLoading(clsUtility.strProjectTitle, "Loading please Wait..", this, imgLoading);                        
            SendMail Obj = new SendMail();
            try
            {
                Obj.To = "abdulmateen50@gmail.com,Khan89aamir@gmail.com";
                Obj.Sub = subject;
                Obj.Body = body;
                Obj.SendEMail();
                b = Obj.IsMail;
            }
            catch
            {
                ObjThread.CloseImageLoadingDialog();
            }
        }
        private void DataSave()
        {
            ObjDAL.UpdateColumnData("SoftKey", SqlDbType.VarChar, txtEncKey.Text.Trim());
            ObjDAL.UpdateColumnData("ExpiryDate", SqlDbType.VarChar, Objutil.Encrypt(dtpExpiryDate.Value.ToString(), true));
            ObjDAL.UpdateColumnData("IsTrail", SqlDbType.Bit, Istrial.Checked);
            if (DBName.Length > 0)
            {
                ObjDAL.UpdateData(DBName + ".dbo.RegistrationDetails", "PcName='" + Environment.MachineName + "'");
            }
            else
            {
                ObjDAL.UpdateData("dbo.RegistrationDetails", "PcName='" + Environment.MachineName + "'");
            }
        }
        private bool Validation()
        {
            txtEncKey.Clear();
            if (Obj.IsControlTextEmpty(txtCustomerName))
            {
                clsUtility.ShowInfoMessage("Enter Customer Name   ", clsUtility.strProjectTitle);
                txtCustomerName.Focus();
                return false;
            }
            else if (Obj.IsControlTextEmpty(txtProductName))
            {
                clsUtility.ShowInfoMessage("Enter Product Name   ", clsUtility.strProjectTitle);
                txtProductName.Focus();
                return false;
            }
            else if (Obj.IsControlTextEmpty(txtOrganisation))
            {
                clsUtility.ShowInfoMessage("Enter Organisation Name   ", clsUtility.strProjectTitle);
                txtOrganisation.Focus();
                return false;
            }
            else if (Obj.IsControlTextEmpty(txtMobileNo))
            {
                clsUtility.ShowInfoMessage("Enter Mobile Number   ", clsUtility.strProjectTitle);
                txtMobileNo.Focus();
                return false;
            }
            else if (Obj.IsControlTextEmpty(txtEmail))
            {
                clsUtility.ShowInfoMessage("Enter Email Address             ", clsUtility.strProjectTitle);
                txtEmail.Focus();
                return false;
            }
            else if (Obj.IsControlTextEmpty(txtAddress))
            {
                clsUtility.ShowInfoMessage("Enter Address   ", clsUtility.strProjectTitle);
                txtAddress.Focus();
                return false;
            }
            else
            {
                if (Obj.ValidateEmail(txtEmail.Text))
                {
                    if (txtMobileNo.Text.Trim().Length >= 10 && txtEmail.Text.Trim().Length >= 10)
                    {
                        return true;
                    }
                    else
                    {
                        clsUtility.ShowErrorMessage("Enter Mobile Number or Email Address", clsUtility.strProjectTitle);
                        txtMobileNo.Focus();
                        return false;
                    }
                }
                else
                {
                    clsUtility.ShowErrorMessage("Enter Valid Email Address ", clsUtility.strProjectTitle);
                    txtEmail.Focus();
                    return false;
                }
            }
        }

        private void btnActivate_Click(object sender, EventArgs e)
        {
            if (txtKey.Text.Trim().Length == 0)
            {
                clsUtility.ShowInfoMessage("Enter Registration Key to Activate this Product", clsUtility.strProjectTitle);
                txtKey.Focus();
                return;
            }
            else if (strRealKey == txtKey.Text.Trim())
            {
                //DataSave();
                //isexit = false;
                customerData = "DataBase Name : " + DBName + "\n" +
                                  "Encrypted Key : " + strRealKey + "\n" +
                                  "Customer Name : " + txtCustomerName.Text.Trim() + "\n" +
                                  "Product Name : " + txtProductName.Text.Trim() + "\n" +
                                  "Organisation Name : " + txtOrganisation.Text.Trim() + "\n" +
                                  "Mobile Number : " + txtMobileNo.Text.Trim() + "\n" +
                                  "Email ID : " + txtEmail.Text.Trim() + "\n" +
                                  "Address : " + txtAddress.Text.Trim() + "\n" +
                                  "Expiry Date(DD/MM/YYYY) : " + dtpExpiryDate.Value.ToString("dd/MM/yyyy") + "\n" +
                                  "Is Trail : " + Istrial.Checked;
                string body = "Product key has been entered in " + clsUtility.strProjectTitle + " project and entered in Machine " + Environment.MachineName +
                   "\n" + customerData;

                ObjDAL.UpdateColumnData("IsKeyEnter", SqlDbType.Bit, 1);
                if (ObjDAL.UpdateData(DBName + ".dbo.RegistrationDetails", "PcName='" + Environment.MachineName + "'") > 0)
                {
                    clsUtility.ShowInfoMessage("Thank you for Registering " + clsUtility.strProjectTitle, clsUtility.strProjectTitle);
                    SendEmail("Product key has been Entered in " + clsUtility.strProjectTitle, body);
                    //if (System.IO.File.Exists(exeName + ".exe"))
                    //    System.Diagnostics.Process.Start(exeName + ".exe");
                    Application.Exit();
                }
            }
            else
            {
                clsUtility.ShowErrorMessage("Invalid Key  ", clsUtility.strProjectTitle);
                txtKey.Focus();
                return;
            }
            Application.Exit();
        }

        private void CustomerRegister_Load(object sender, EventArgs e)
        {
            btnRegister.BackgroundImage = B_Leave;
            btnActivate.BackgroundImage = B_Leave;
            dtpExpiryDate.MaxDate = DateTime.Now.AddYears(1);
            dtpExpiryDate.Value = DateTime.Now.AddDays(7);
            if (ObjDAL.ConnectionObject.ConnectionString == String.Empty)
                ObjDAL.SetConnectionString(clsDMCommon.ObjCon.ConnectionString);
            DBName = ObjDAL.GetCurrentDBName(true);
        }

        private void btnRegister_MouseEnter(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Enter;
        }

        private void btnRegister_MouseLeave(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            btn.BackgroundImage = B_Leave;
        }

        private void CustomerRegister_FormClosing(object sender, FormClosingEventArgs e)
        {
            try
            {
                if (isexit)
                {
                    Application.Exit();
                }
            }
            catch
            {
                Application.Exit();
            }
        }

        private void txtCustomerName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Objutil.IsString(e) == false)
            {
                e.Handled = false;
            }
            else
            {
                clsUtility.ShowErrorMessage("Enter Only Charactors ", clsUtility.strProjectTitle);
                txtCustomerName.Focus();
                e.Handled = true;
            }
        }

        private void txtMobileNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Objutil.IsNumeric(e) == false)
            {
                e.Handled = false;
            }
            else
            {
                if (e.KeyChar != 47)
                {
                    clsUtility.ShowErrorMessage("Enter Only Numbers ", clsUtility.strProjectTitle);
                }
                if (e.KeyChar == 47 && txtMobileNo.TextLength == 10 || txtMobileNo.TextLength == 21 || txtMobileNo.TextLength == 32 || txtMobileNo.TextLength == 43)
                {
                    e.Handled = false;
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void MouseFoucsEnter(object sender, EventArgs e)
        {
            Objutil.SetTextHighlightColor(sender);
        }
        private void MouseFoucsLeave(object sender, EventArgs e)
        {
            Objutil.SetTextHighlightColor(sender, Color.White);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                //ObjThread.ShowImageLoading(clsUtility.strProjectTitle, "Generating Key please Wait..", this, null);
                //ObjThread.ShowLoadingDialog(clsUtility.strProjectTitle, "Generating Key please Wait..", this);
                Thread th = new Thread(new ThreadStart(LoadData));
                //th.SetApartmentState(ApartmentState.STA);
                th.Start();
                string sub = "Customer have product key.";
                string body = "Request for a new product key. from Machine : " + Environment.MachineName + " has requested for a new product key for \n" + customerData;

                SendEmail(sub, body);
                //if (b)
                //{
                //    clsUtility.ShowInfoMessage("An E-Mail has been sent to the software developers for a Product Key.\nYou will receive your Product Key at your E-Mail Address", clsUtility.strProjectTitle);
                //}
                //else
                //{
                //    clsUtility.ShowInfoMessage("Unable to Send An E-Mail for Registration Key request.", clsUtility.strProjectTitle);
                //}
                btnRegister.Enabled = false;
                txtKey.Enabled = true;
                txtKey.Focus();
                btnActivate.Enabled = true;
            }
            else
            {
                btnRegister.Enabled = true;
                txtKey.Clear();
                txtEncKey.Clear();
                txtKey.Enabled = false;
                btnActivate.Enabled = false;
            }
        }
    }
}