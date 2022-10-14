using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_library
{
    public class deptmaster
    {
        [Key]
        [Required]
        public int deptcode { get; set; }
        [MaxLength(20, ErrorMessage = "Not allowed above 20 chars")]
        [MinLength(2, ErrorMessage = "Not allowed below 2 chars")]
        public string deptname { get; set; }

        public virtual ICollection<empprofile> empprofile { get; set; }
    }


    public class empprofile
    {
        [Key]
        public int empcode { get; set; }
        public DateTime dob { get; set; }

        public string empname { get; set; }

        public string email { get; set; }
        public int deptcode { get; set; }
        [ForeignKey("deptcode")]
        public virtual deptmaster decode { get; set; }

    }
    public class MyContext : DbContext
    {
        public MyContext() : base("MyContext")
        {

            Database.SetInitializer<MyContext>(new DropCreateDatabaseIfModelChanges<MyContext>());
        }

        public virtual DbSet<deptmaster> depttable { get; set; }
        public virtual DbSet<empprofile> emptable { get; set; }


    }
    


}
