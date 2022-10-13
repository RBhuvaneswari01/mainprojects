using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BLL_library;

namespace Library
{
    public class Class1
    {
        DataSet ds = null;
        SqlDataAdapter da = null;
        SqlConnection sql = null;
        public Class1()
        {
            sql = new SqlConnection("Data Source=DESKTOP-0NA7TAB\\SQLEXPRESS;Initial Catalog=RainbowDB;Integrated Security=True");
            ds = new DataSet();
        }
        private DataTable Connect()
        {
            da = new SqlDataAdapter("select * from student", sql);



            da.Fill(ds, "student");
            DataTable dt_proddata = ds.Tables["student"];
            return dt_proddata;
        }
       
        public string FindProducts(int studid)
        {
            DataTable student = Connect();
            DataColumn[] keycolumns = new DataColumn[1];
            keycolumns[0] = student.Columns["studid"];
            student.PrimaryKey = keycolumns;
            DataRow dr = student.Rows.Find(studid);
            string ans = dr[0].ToString() + " " + dr[1].ToString() + " " + dr[3].ToString();
            return ans;
        }
        
    }
}
