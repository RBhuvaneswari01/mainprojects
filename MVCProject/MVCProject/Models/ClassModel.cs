using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCProject.Models
{
    public class ClassModel
    {
        private int classno;

        public int Classno
        {
            get { return classno; }
            set { classno = value; }
        }
        private string classsec;

        public string Classsec
        {
            get { return classsec; }
            set { classsec = value; }
        }


    }
}