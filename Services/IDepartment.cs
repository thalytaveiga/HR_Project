using HR_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Project.Services
{
    public interface IDepartment
    {
        IEnumerable<Department> GetDepartments { get; }
        Department GetDepartment (int? Id);
        void Add(Department _Department);
        void Remove(int? Id);
    }
}
