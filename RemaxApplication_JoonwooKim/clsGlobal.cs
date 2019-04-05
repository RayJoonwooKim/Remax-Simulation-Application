using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;
namespace RemaxApplication_JoonwooKim
{
    static class clsGlobal
    {
        public static OleDbConnection myCon;
        public static OleDbCommand myCmd, myCmd2, myCmd3, myCmd4;
        public static string path;
        public static string load_profile;
        public static int ref_client;
        public static DataSet mySet;
        public static DataRow Row_Agent, Row_Client;
        public static OleDbDataAdapter adpAdmin, adpEmp, adpClient, adpHouse, adpSales;
        public static List<DataRow> Row_House;
    }
}
