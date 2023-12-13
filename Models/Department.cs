using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MSMSwebapipro.Models
{
    [Table("Department")]
    public class Department
    {
        [Key]
        public int DeptNo { get; set; }
        public string Dname { get; set; }
        public string locatin { get; set; }

        public ICollection<Employee> employees { get; set; }
    }
}
