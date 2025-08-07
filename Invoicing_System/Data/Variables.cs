using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Invoicing_System.Data
{
    public class Variables : AppData
    {
        public string _title = "INVOICE SYSTEM";
        public MySqlConnection con = new MySqlConnection(AppDbCon);
        public MySqlCommand cmd;
        public MySqlDataReader dr;
        public MySqlDataAdapter da;
        public DataTable dt;
        public DataSet ds;

        private static string user_uname;
        public static string user_unameValue
        {
            get { return user_uname; }
            set { user_uname = value; }
        }

        private static string user_compaccess;
        public static string User_CompAccess
        {
            get { return user_compaccess; }
            set { user_compaccess = value; }
        }

        private static bool isActive;
        public static bool isActiveValue
        {
            get { return isActive; }
            set { isActive = value; }
        }

        private static bool isSupervisor;
        public static bool isSupervisorValue
        {
            get { return isSupervisor; }
            set { isSupervisor = value; }
        }

        private static bool isAdmin;
        public static bool isAdminValue
        {
            get { return isAdmin; }
            set { isAdmin = value; }
        }

        private static bool isViewing;
        public static bool isViewingValue
        {
            get { return isViewing; }
            set { isViewing = value; }
        }

        public string Text { get; set; }
        public int Value { get; set; }

        public class Company
        {
            public string CompanyID { get; set; }
            public string CompanyName { get; set; }
            public int InvoiceNoSeries { get; set; }

            public override string ToString()
            {
                return CompanyName;
            }
        }
    }
}
