using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace RemaxApplication_JoonwooKim.DataSource
{
    public static class clsAdmin
    {
        public static DataRow AgentLogin(string ID, string password, string profile)
        {
            if (profile == "Agent")
            {
                foreach (DataRow i in clsGlobal.mySet.Tables["Employee"].Rows)
                {
                    if (ID == i["EmpID"].ToString() && password == i["EmpPW"].ToString() && profile == i["Post"].ToString())
                    {
                        return i;
                    }
                }
            }
            return null;
        }

        public static DataRow GetClientInfo(DataRow tmp)
        {
            foreach (DataRow i in clsGlobal.mySet.Tables["Client"].Rows)
            {
                if (i["RefEmp"].ToString() == tmp["RefEmp"].ToString())
                {
                    return i;
                }
            }
            return null;
        }
        public static List<DataRow> GetHouseRef(int id)
        {
            List<DataRow> res = new List<DataRow>();
            List<int> RefHouse_Arr = new List<int>();
            foreach (DataRow i in clsGlobal.mySet.Tables["Client"].Rows)
            {
                if ((int)i["RefEmp"] == id)
                {
                    RefHouse_Arr.Add((int)i["RefHouse"]);
                }
            }
            foreach (DataRow i in clsGlobal.mySet.Tables["House"].Rows)
            {
                foreach (int t in RefHouse_Arr)
                {
                    if ((int)i["RefHouse"] == t)
                    {
                        res.Add(i);
                    }
                }
            }
            return res;
        }
        
            
        public static DataRow AdminLogin(string ID, string password, string profile)
        {
            if (profile == "Administrator")
            {
                foreach (DataRow i in clsGlobal.mySet.Tables["Employee"].Rows)
                {
                    if (ID == i["EmpID"].ToString() && password == i["EmpPW"].ToString() && profile == i["Post"].ToString())
                    {
                        return i;
                    }
                }
            }
            return null;
        }
        public static void AddNewEmp(OleDbConnection con, string path, DataTable tab, string id, string pw, string fn, string ln, string phone, string pos)
        {
            con = new OleDbConnection(path);
            con.Open();

            DataRow myRow = tab.NewRow();

            myRow["EmpID"] = id;
            myRow["EmpPW"] = pw;
            myRow["FirstName"] = fn;
            myRow["LastName"] = ln;
            myRow["Phone"] = phone;
            myRow["Post"] = pos;

            tab.Rows.Add(myRow);
            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(clsGlobal.adpEmp);
            clsGlobal.adpEmp.Update(tab);
        }

        public static void AddNewClient(OleDbConnection con, string path, DataTable tab, string fn, string ln, string phone, string type, string re, string rh)
        {
            con = new OleDbConnection(path);
            con.Open();

            DataRow myRow = tab.NewRow();

            
            myRow["ClientFirstName"] = fn;
            myRow["ClientLastName"] = ln;
            myRow["ClientPhone"] = phone;
            myRow["ClientType"] = type;
            myRow["RefEmp"] = re;
            myRow["RefHouse"] = rh;

            tab.Rows.Add(myRow);
            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(clsGlobal.adpClient);
            clsGlobal.adpClient.Update(tab);
        }

        public static void AddNewHouse(OleDbConnection con, string path, DataTable tab, string loc, string type, string contact, decimal price, int room)
        {
            con = new OleDbConnection(path);
            con.Open();

            DataRow myRow = tab.NewRow();

            myRow["Location"] = loc;
            myRow["Type"] = type;
            myRow["Contact"] = contact;
            myRow["Price"] = price;
            myRow["Room"] = room;

            tab.Rows.Add(myRow);
            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(clsGlobal.adpHouse);
            clsGlobal.adpHouse.Update(tab);
        }
        public static void UpdateEmp (OleDbConnection con, string path, DataTable tab, int current, string id, string pw, string fn, string ln, string phone, string pos)
        {
            con = new OleDbConnection(path);
            con.Open();

            DataRow myRow = tab.Rows[current];

            myRow["EmpID"] = id;
            myRow["EmpPW"] = pw;
            myRow["FirstName"] = fn;
            myRow["LastName"] = ln;
            myRow["Phone"] = phone;
            myRow["Post"] = pos;
            
            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(clsGlobal.adpEmp);
            clsGlobal.adpEmp.Update(tab);

        }

        public static void UpdateClient(OleDbConnection con, string path, DataTable tab, int current, string fn, string ln, string phone, string type, string re, string rh)
        {
            con = new OleDbConnection(path);
            con.Open();

            DataRow myRow = tab.Rows[current];

           
            myRow["ClientFirstName"] = fn;
            myRow["ClientLastName"] = ln;
            myRow["ClientPhone"] = phone;
            myRow["ClientType"] = type;
            myRow["RefEmp"] = re;
            myRow["RefHouse"] = rh;
            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(clsGlobal.adpClient);
            clsGlobal.adpClient.Update(tab);
        }
        
        public static void UpdateHouse(OleDbConnection con, string path, DataTable tab, int current, string loc, string type, string contact, decimal price, int room)
        {
            con = new OleDbConnection(path);
            con.Open();

            DataRow myRow = tab.Rows[current];

            myRow["Location"] = loc;
            myRow["Type"] = type;
            myRow["Contact"] = contact;
            myRow["Price"] = price;
            myRow["Room"] = room;

            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(clsGlobal.adpHouse);
            clsGlobal.adpHouse.Update(tab);
        }
        public static void UpdateSales(OleDbConnection con, string path, DataTable tab, int current, string status)
        {
            con = new OleDbConnection(path);
            con.Open();

            DataRow myRow = tab.Rows[current];

            //myRow["RefSales"] = sales;
            //myRow["RefEmp"] = emp;
            //myRow["RefClient"] = client;
            //myRow["RefHouse"] = house;
            myRow["Status"] = status;

            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(clsGlobal.adpSales);
            clsGlobal.adpSales.Update(tab);
        }
        public static void DeleteEmp (OleDbConnection con, string path, DataTable tab, int current)
        {
            con = new OleDbConnection(clsGlobal.path);
            con.Open();
            tab.Rows[current].Delete();

            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(clsGlobal.adpEmp);
            clsGlobal.adpEmp.Update(tab);
            

        }

        public static void DeleteClient(OleDbConnection con, string path, DataTable tab, int current)
        {
            con = new OleDbConnection(clsGlobal.path);
            con.Open();
            tab.Rows[current].Delete();

            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(clsGlobal.adpClient);
            clsGlobal.adpClient.Update(tab);



        }

        public static void DeleteHouse(OleDbConnection con, string path, DataTable tab, int current)
        {
            con = new OleDbConnection(clsGlobal.path);
            con.Open();
            tab.Rows[current].Delete();

            OleDbCommandBuilder myBuilder = new OleDbCommandBuilder(clsGlobal.adpHouse);
            clsGlobal.adpHouse.Update(tab);


        }

        
    }
}
