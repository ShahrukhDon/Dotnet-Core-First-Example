using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace POSTS.Models
{
    public class WorkoutContext : DbContext
    {
        public WorkoutContext(DbContextOptions<WorkoutContext> options)
            :base(options)
        {

        }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Employee> Employees { get; set; }
    }
}
