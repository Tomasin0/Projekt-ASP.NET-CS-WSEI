using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjektASP.Models
{
    public class TaskM8Context : DbContext
    {
        public TaskM8Context(DbContextOptions options) : base(options)
        {
        }
        public DbSet<TaskModel> Tasks { get; set;  }
        
    }
}
