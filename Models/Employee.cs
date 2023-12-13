using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSMSwebapipro.Models
{
    [Table("Employee")]
    public class Employee
    {
        [Key]
        public int Empid { get; set; }

        public string Ename { get; set; }
        
        public string password { get; set; }

        
        public string gender { get; set; }
       
        public string phone { get; set; }
       
        public string Email { get; set; }
        
       
        public decimal Salary { get; set; }
        
        public string address { get; set; }

        [ForeignKey("Department")]
        public int DeptNo { get; set; }//making relation with department table with only one number i,e "DEPTNO"
        public bool Active { get; set; }
        public Department Department { get; set; }//only one department member belong to one department table

    }
}
