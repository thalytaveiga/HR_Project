using HR_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Project.Services
{
    public interface IEmployee
    {
        IEnumerable<Employee> GetEmployees { get; }
        Employee GetEmployee (int? Id);
        void Add(Employee _Employee);
        void Remove(int? Id);

    }
}
