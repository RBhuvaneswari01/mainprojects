using BLL_library;
using DAL_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EMFProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bll_class co = new bll_class();
            List<empprofile> employees = co.ShowEmployeeList();

            foreach (var item in employees)
            {
                Console.WriteLine(item.empcode + " " + item.empname +" "+ item.dob+ " "+ item.email+ " "+ item.deptcode);
            }

            Console.WriteLine("--------------------------");
            empprofile bal = new empprofile();
            Console.WriteLine("Add employee");
            Console.WriteLine("enter empcode");

            bal.empcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("entr empname");
            bal.empname = Console.ReadLine();

            Console.WriteLine("enter email");
            bal.email = Console.ReadLine();
            Console.WriteLine("enter deptcode");

            bal.deptcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter dob");

            bal.dob = Convert.ToDateTime(Console.ReadLine());

            co.AddEmployee(bal);
            Console.WriteLine("record Inserted successfully...");
            Console.WriteLine("=---------------------------");
            empprofile bal1 = new empprofile();
            Console.WriteLine("Update Employee");
            Console.WriteLine("enter empcode to update");
            bal1.empcode = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter empname");
            bal1.empname = Console.ReadLine();
            Console.WriteLine("enter dob");
            bal1.dob = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("enter email");
            bal1.email = Console.ReadLine();
            Console.WriteLine("enter deptcode ");
            bal1.deptcode = Convert.ToInt32(Console.ReadLine());
            co.EditEmployee(bal);
            Console.WriteLine("Updated successfully");
            Console.WriteLine("------------------------------");
            Console.WriteLine("Delete employee using empcode");
            Console.WriteLine("enter empcode to delete");
            int empcode = Convert.ToInt32(Console.ReadLine());
            co.RemoveEmployee(empcode);
            Console.WriteLine("Deleted successfully....");
            Console.ReadLine();
            //MyContext context = new MyContext();
            //context.depttable.Add(new deptmaster { deptcode = 1, deptname = "ECE" });
            //context.depttable.Add(new deptmaster { deptcode = 2, deptname = "CSE" });
            //context.depttable.Add(new deptmaster { deptcode = 3, deptname = "MECH" });
            //context.depttable.Add(new deptmaster { deptcode = 4, deptname = "CIVIL" });
            //context.depttable.Add(new deptmaster { deptcode = 5, deptname = "EEE" });
            //context.depttable.Add(new deptmaster { deptcode = 6, deptname = "AID" });
            //context.depttable.Add(new deptmaster { deptcode = 7, deptname = "IT" });

            //context.emptable.Add(new empprofile { empcode = 1, empname = "bhuvana", dob = new DateTime(2000, 08, 01) ,email="bhuvana@123",deptcode=1});
            //context.emptable.Add(new empprofile { empcode = 2, empname = "mamatha", dob = new DateTime(1998, 09, 21), email = "mamatha@112", deptcode = 2 });
            //context.emptable.Add(new empprofile { empcode = 3, empname = "chinnu", dob = new DateTime(2009, 03, 13), email = "chinnu@567", deptcode = 3 });
            //context.emptable.Add(new empprofile { empcode = 4, empname = "koushik", dob = new DateTime(2010, 02, 11), email = "koushik@345", deptcode = 4 });
            //context.emptable.Add(new empprofile { empcode = 5, empname = "shanvi", dob = new DateTime(2021, 10, 12), email = "shanvi@456", deptcode = 5 });
            //context.emptable.Add(new empprofile { empcode = 6, empname = "minnu", dob = new DateTime(2021, 03, 15), email = "minnu@123", deptcode = 6 });
            //context.emptable.Add(new empprofile { empcode = 7, empname = "sandeep", dob = new DateTime(2001, 09, 11), email = "sandeep@123", deptcode = 7 });
            //context.SaveChanges();
            //Console.WriteLine("done");
            //Console.Read();
        }
    }
}
