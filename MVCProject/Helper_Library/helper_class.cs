using BLL_Library;
using DAL_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper_Library
{
    public class helper_class
    {
        DAL_Class dal = null;
        public helper_class()
        {
            dal = new DAL_Class();
        }
        public List<BLL_Class> ShowStudentList()
        {
            return dal.StudentList();
        }
        public bool RemoveStudent(int studid)
        {
            return dal.DeleteStudent(studid);
        }
        public BLL_Class SearchStudent(int studid)
        {
            return dal.FindStudent(studid);
        }

        public void SearchStudent(int studid, out BLL_Class empdata)
        {

            dal.FindStudent(studid, out empdata);


        }
        public bool AddStudent(BLL_Class student)
        {
            return dal.InsertStudent(student);

        }
        public bool EditStudent(BLL_Class studid)
        {
            return dal.UpdateStudent(studid);
        }
        //=========================================================================================================
        public List<BLL_Class> ShowSubjectList()
        {
            return dal.SubjectList();
        }
        //==============================================================================================================
        public List<BLL_Class> ShowClassList()
        {
            return dal.classList();
        }
    }
}
