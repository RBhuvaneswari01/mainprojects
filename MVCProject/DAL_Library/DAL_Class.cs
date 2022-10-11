using BLL_Library;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace DAL_Library
{
    public class DAL_Class
    {
        public List<BLL_Class> StudentList()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RainbowCnString"].ConnectionString);

            SqlCommand cmdlist = new SqlCommand("select * from  [dbo].[fn_Studlist]()", cn);
            cn.Open();
            SqlDataReader dr = cmdlist.ExecuteReader();
            List<BLL_Class> studlist = new List<BLL_Class>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    BLL_Class bal = new BLL_Class();
                    bal.StudentID = Convert.ToInt32(dr["studid"]);
                    bal.StudentName = dr["studname"].ToString();
                    bal.StudentClass = Convert.ToInt32(dr["Studclass"]);

                    studlist.Add(bal);
                }
            }
            cn.Close();
            cn.Dispose();
            return studlist;

        }
        public bool DeleteStudent(int studid)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RainbowCnString"].ConnectionString);

            SqlCommand cmdDelete = new SqlCommand("[dbo].[sp_DeleteStudent]", cn);
            cmdDelete.CommandType = System.Data.CommandType.StoredProcedure;
            cmdDelete.Parameters.AddWithValue("@p_studid", studid);
            cn.Open();
            int i = cmdDelete.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            cn.Close();//finally
            cn.Dispose();//finally
            return status;

        }
        public BLL_Class FindStudent(int studid)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RainbowCnString"].ConnectionString);
            SqlCommand cmdSelect = new SqlCommand("[dbo].[sp_FindStudent]", cn);
            cmdSelect.CommandType = System.Data.CommandType.StoredProcedure;
            cmdSelect.Parameters.AddWithValue("@p_studid", studid);

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@p_studname";
            p1.SqlDbType = System.Data.SqlDbType.NVarChar;
            p1.Size = 10;
            p1.Direction = System.Data.ParameterDirection.Output;
            cmdSelect.Parameters.Add(p1);


            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@p_studclass";
            p2.SqlDbType = System.Data.SqlDbType.NVarChar;
            p2.Size = 20;
            p2.Direction = System.Data.ParameterDirection.Output;
            cmdSelect.Parameters.Add(p2);




            cn.Open();
            cmdSelect.ExecuteNonQuery();

            BLL_Class studfound = new BLL_Class();

            studfound.StudentName = p1.Value.ToString();
            studfound.StudentClass = Convert.ToInt32(p2.Value);




            cn.Close();
            cn.Dispose();


            return studfound;



        }



        public void FindStudent(int studid, out BLL_Class studdata)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RainbowCnString"].ConnectionString);
            SqlCommand cmdSelect = new SqlCommand("[dbo].[sp_FindStudent]", cn);
            cmdSelect.CommandType = System.Data.CommandType.StoredProcedure;
            cmdSelect.Parameters.AddWithValue("@p_studid", studid);

            SqlParameter p1 = new SqlParameter();
            p1.ParameterName = "@p_studname";
            p1.SqlDbType = System.Data.SqlDbType.NVarChar;
            p1.Size = 10;
            p1.Direction = System.Data.ParameterDirection.Output;
            cmdSelect.Parameters.Add(p1);


            SqlParameter p2 = new SqlParameter();
            p2.ParameterName = "@p_studclass";
            p2.SqlDbType = System.Data.SqlDbType.NVarChar;
            p2.Size = 20;
            p2.Direction = System.Data.ParameterDirection.Output;
            cmdSelect.Parameters.Add(p2);





            cn.Open();
            cmdSelect.ExecuteNonQuery();

            studdata = new BLL_Class();

            studdata.StudentName = p1.Value.ToString();

            studdata.StudentClass = Convert.ToInt32(p2.Value);
            BLL_Class sdata = new BLL_Class();
            sdata = studdata;



            cn.Close();
            cn.Dispose();






        }
        public bool InsertStudent(BLL_Class student)
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RainbowCnString"].ConnectionString);

            SqlCommand cmdInsert = new SqlCommand("insert into Student(studid,studname,studclass) values(@studid,@studame,@studclass)", cn);
            cmdInsert.Parameters.AddWithValue("@studid", student.StudentID);
            cmdInsert.Parameters.AddWithValue("@studname", student.StudentName);
            cmdInsert.Parameters.AddWithValue("@studclass", student.StudentClass);

            cn.Open();
            int i = cmdInsert.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            cn.Close();
            cn.Dispose();
            return status;

        }
        public bool UpdateStudent(BLL_Class student)
        {

            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RainbowCnString"].ConnectionString);

            SqlCommand cmdUpdate = new SqlCommand("[dbo].sp_UpdateStudent", cn);

            cmdUpdate.CommandType = System.Data.CommandType.StoredProcedure;
            cmdUpdate.Parameters.AddWithValue("@p_studid", student.StudentID);
            cmdUpdate.Parameters.AddWithValue("@p_studname", student.StudentName);
            cmdUpdate.Parameters.AddWithValue("@p_studclass", student.StudentClass);

            cn.Open();
            int i = cmdUpdate.ExecuteNonQuery();
            bool status = false;
            if (i == 1)
            {
                status = true;
            }
            cn.Close();//finally
            cn.Dispose();//finally
            return status;

        }
        //=========================================================================================================================
        public List<BLL_Class> SubjectList()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RainbowCnString"].ConnectionString);

            SqlCommand cmdlist = new SqlCommand("select * from  [dbo].[fn_SubjectList]()", cn);
            cn.Open();
            SqlDataReader dr = cmdlist.ExecuteReader();
            List<BLL_Class> sublist = new List<BLL_Class>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    BLL_Class bal = new BLL_Class();
                    bal.Subid = Convert.ToInt32(dr["subid"]);
                    bal.Subname = dr["subname"].ToString();


                    sublist.Add(bal);
                }
            }
            cn.Close();
            cn.Dispose();
            return sublist;
        }
        //===========================================================================================
        public List<BLL_Class> classList()
        {
            SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["RainbowCnString"].ConnectionString);

            SqlCommand cmdlist = new SqlCommand("SELECT * FROM [dbo].fn_classlist()", cn);
            cn.Open();
            SqlDataReader dr = cmdlist.ExecuteReader();
            List<BLL_Class> classlist = new List<BLL_Class>();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    BLL_Class bal = new BLL_Class();


                    bal.Classno = Convert.ToInt32(dr["classno"]);
                    bal.Classsec = dr["classsec"].ToString();


                    classlist.Add(bal);
                }
            }
            cn.Close();
            cn.Dispose();
            return classlist;

        }
    }
}
