using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace POSTS.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
        public string EMPCode { get; set; }
        public string Mobile { get; set; }
        public string Position { get; set; }
    }
}
