using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using CoreApp;

namespace RegistrationProcess
{
	class clsDMCommon
	{
        public static SqlConnection ObjCon = new SqlConnection();
        public static bool IsConnectAgain = false;
        public static string strServerName;
        public static string strUserID;
        public static string strUserPassword;
        public static bool IsDirectClose = false;
	}
}
