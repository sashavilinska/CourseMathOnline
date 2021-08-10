using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseMathOnline.Models
{
    public class CoursesContext : DbContext
    {
        public DbSet<Courses> Courses { get; set; }
        public DbSet<Student> Student { get; set; }

        public CoursesContext(DbContextOptions<CoursesContext> options)
            : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
