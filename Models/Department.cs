using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HR_Project.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }

        [DisplayName("Department Name")]
        [Required(ErrorMessage = "Department Name is Required.")]
        public string DeptName { get; set; }

        [DisplayName("Department Location")]
        [Required(ErrorMessage = "Department Location is Required.")]
        public string DeptLocation { get; set; }

        public ICollection<Employee> Employees { get; set; }

        //public Employee Employees { get; set; }
    }
}
