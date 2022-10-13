using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    public class Class4
    {
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection sql = null;
        public Class4()
        {
            sql = new SqlConnection("Data Source=DESKTOP-0NA7TAB\\SQLEXPRESS;Initial Catalog=RainbowDB;Integrated Security=True");
            ds = new DataSet();
        }
        private DataTable Connect()
        {
            da = new SqlDataAdapter("select * from subject", sql);



            da.Fill(ds, "subject");
            DataTable dt_proddata = ds.Tables["subject"];
            return dt_proddata;
        }

        public string FindProducts(int classno)
        {
            DataTable sub = Connect();
            DataColumn[] keycolumns = new DataColumn[1];
            keycolumns[0] = sub.Columns["subid"];
            sub.PrimaryKey = keycolumns;
            DataRow dr = sub.Rows.Find(classno);
            string ans = dr[0].ToString() + " " + dr[1].ToString();
            return ans;
        }
    }
}
