using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL_library
{
    public class BLL_Class
    {
        private int _studid;

        public int StudentID
        {
            get { return _studid; }
            set { _studid = value; }
        }

        private string _studname;

        public string StudName
        {

            get { return _studname; }
            set { _studname = value; }
        }
        private int _studclass;

        public int StudentClass
        {
            get { return _studclass; }
            set { _studclass = value; }
        }
        private int _studmarks;

        public int studmarks
        {
            get { return _studmarks; }
            set { _studmarks = value; }
        }
    }
}
