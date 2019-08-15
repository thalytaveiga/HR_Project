using HR_Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HR_Project.Services
{
    public interface IJobRole
    {
        IEnumerable<JobRole> GetJobRoles { get; }
        JobRole GetJobRole(int? Id);
        void Add(JobRole _JobRole);
        void Remove(int? Id);
    }
}
