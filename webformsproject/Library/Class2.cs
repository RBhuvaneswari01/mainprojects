using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Class2
    {
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection sql = null;
        public Class2()
        {
            sql = new SqlConnection("Data Source=DESKTOP-0NA7TAB\\SQLEXPRESS;Initial Catalog=RainbowDB;Integrated Security=True");
            ds = new DataSet();
        }
        private DataTable Connect()
        {
            da = new SqlDataAdapter("select * from class", sql);



            da.Fill(ds, "class");
            DataTable dt_proddata = ds.Tables["class"];
            return dt_proddata;
        }

        public string FindProducts(int classno)
        {
            DataTable class3 = Connect();
            DataColumn[] keycolumns = new DataColumn[1];
            keycolumns[0] = class3.Columns["classno"];
            class3.PrimaryKey = keycolumns;
            DataRow dr = class3.Rows.Find(classno);
            string ans = dr[0].ToString() + " " + dr[1].ToString();
            return ans;
        }
    }
}
