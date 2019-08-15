using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HR_Project.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [DisplayName("First Name")]
        [Required(ErrorMessage = "First Name is Required.")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        [Required(ErrorMessage = "Last Name is Required.")]
        public string LastName { get; set; }

        [DisplayName("Job Name")]
        [Required(ErrorMessage = "Job Name is Required.")]
        public int JobId { get; set; }

        [DisplayName("Department Name")]
        [Required(ErrorMessage = "Department Name is Required.")]
        public int DeptId { get; set; }

        [DataType(DataType.Date)]
        public DateTime HireDate { get; set; }

        [DisplayName("Salary")]
        [Required(ErrorMessage = "Salary is Required.")]
        public decimal Salary { get; set; }

        public Department Departments { get; set; }

        public JobRole JobRoles { get; set; }

        //public ICollection<JobRole> JobRoles { get; set; }
    }
}
