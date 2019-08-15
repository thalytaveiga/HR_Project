using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HR_Project.Models;
using Microsoft.EntityFrameworkCore;

namespace HR_Project.Repository
{
    public class DB_Context : DbContext
    {
        public DB_Context(DbContextOptions<DB_Context> options) : base(options)
        {

        }
        //We should keep the name that we use in front of DbSets exactly the same as of our database tables name.
        public DbSet<Employee> Employee { get; set; }
        public DbSet<JobRole> JobRole { get; set; }
        public DbSet<Department> Department { get; set; }
    }
}