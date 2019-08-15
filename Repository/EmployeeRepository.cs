using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Project.Models;
using HR_Project.Services;
using Microsoft.EntityFrameworkCore;

namespace HR_Project.Repository
{
    public class EmployeeRepository : IEmployee
    {
        private DB_Context db;

        public EmployeeRepository(DB_Context _db)
        {
            db = _db;
        }

        public IEnumerable<Employee> GetEmployees => db.Employee.Include(d => d.Departments).Include(j => j.JobRoles);

        //public IEnumerable<Employee> GetEmployees => db.Employee;

        public void Add(Employee _Employee)
        {
            if (_Employee.EmpId == 0)
            {
                db.Employee.Add(_Employee);
                db.SaveChanges();
            }
            else
            {
                var dbEntity = db.Employee.Find(_Employee.EmpId);
                dbEntity.FirstName = _Employee.FirstName;
                dbEntity.LastName = _Employee.LastName;
                dbEntity.JobId = _Employee.JobId;
                dbEntity.DeptId = _Employee.DeptId;
                dbEntity.HireDate = _Employee.HireDate;
                dbEntity.Salary = _Employee.Salary;
                db.SaveChanges();
            }
        }

        public Employee GetEmployee(int? Id)
        {
            Employee dbEntity = db.Employee.Include(d => d.Departments)
                                    .Include(j => j.JobRoles)
                                    .SingleOrDefault(e => e.EmpId == Id);
            return dbEntity;
        }

        public void Remove(int? Id)
        {
            Employee dbEntity = db.Employee.Find(Id);
            db.Employee.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
