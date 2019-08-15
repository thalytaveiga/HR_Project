using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Project.Models;
using HR_Project.Services;
using Microsoft.EntityFrameworkCore;

namespace HR_Project.Repository
{
    public class DepartmentRepository : IDepartment
    {
        private DB_Context db;

        public DepartmentRepository(DB_Context _db)
        {
            db = _db;
        }

        public IEnumerable<Department> GetDepartments => db.Department.Include(e => e.Employees);

        public void Add(Department _Department)
        {
            if (_Department.DeptId == 0)
            {
                db.Department.Add(_Department);
                db.SaveChanges();
            }
            else
            {
                var dbEntity = db.Department.Find(_Department.DeptId);
                dbEntity.DeptName = _Department.DeptName;
                dbEntity.DeptLocation = _Department.DeptLocation;
                db.SaveChanges();
            }          
        }

        public Department GetDepartment(int? Id)
        {
            Department dbEntity = db.Department.Include(e => e.Employees)
                .ThenInclude(j => j.JobRoles)
                .SingleOrDefault(m => m.DeptId == Id);
            //.ThenInclude(j => j.JobRoles)
            //.SingleOrDefault(m => m.DeptId == Id);
            //Department dbEntity = db.Department.Include(j => j.JobRoles)
            //                        .Include(e => e.Employees)
            //                        .SingleOrDefault(m => m.DeptId==Id);
            //Department dbEntity = db.Department.Find(Id);
            return dbEntity;
        }

        public void Remove(int? Id)
        {
            Department dbEntity = db.Department.Find(Id);
            db.Department.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
