using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace HR_Project.Models
{
    public class JobRole
    {
        [Key]
        public int JobId { get; set; }

        [DisplayName("Job Name")]
        [Required(ErrorMessage = "Job Name is Required.")]
        public string JobName { get; set; }

        [DisplayName("Department Name")]
        [Required(ErrorMessage = "Department Name is Required.")]
        public int DeptId { get; set; }

        public Department Departments { get; set; }
    }
}
