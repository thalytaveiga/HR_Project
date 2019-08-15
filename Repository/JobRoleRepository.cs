using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Project.Models;
using HR_Project.Services;
using Microsoft.EntityFrameworkCore;

namespace HR_Project.Repository
{
    public class JobRoleRepository : IJobRole
    {
        private DB_Context db;

        public JobRoleRepository(DB_Context _db)
        {
            db = _db;
        }

        public IEnumerable<JobRole> GetJobRoles => db.JobRole.Include(d => d.Departments);

        public void Add(JobRole _JobRole)
        {
            if (_JobRole.JobId == 0)
            {
                db.JobRole.Add(_JobRole);
                db.SaveChanges();
            }
            else
            {
                var dbEntity = db.JobRole.Find(_JobRole.JobId);
                dbEntity.JobName = _JobRole.JobName;
                dbEntity.DeptId = _JobRole.DeptId;
                db.SaveChanges();
            }

        }

        public JobRole GetJobRole(int? Id)
        {
            JobRole dbEntity = db.JobRole.Find(Id);
            //JobRole dbEntity = db.JobRole.Include(d => d.Departments)
            //                        .SingleOrDefault(j => j.JobId);
            return dbEntity;
        }

        public void Remove(int? Id)
        {
            JobRole dbEntity = db.JobRole.Find(Id);
            db.JobRole.Remove(dbEntity);
            db.SaveChanges();
        }
    }
}
