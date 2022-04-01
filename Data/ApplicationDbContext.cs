using Assignment2.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<UniversityStudent> universityStudents { get; set; }
        public DbSet<Prof> profs { get; set; }
        public DbSet<Campus> campuses { get; set; }
        public DbSet<Course> courses { get; set; }
        public DbSet<Major> majors{ get; set; }
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
            
        }
        public DbSet<Assignment2.Models.Prof> Prof { get; set; }
        public DbSet<Assignment2.Models.Campus> Campus { get; set; }
        public DbSet<Assignment2.Models.Course> Course { get; set; }
        public DbSet<Assignment2.Models.Major> Major { get; set; }
    }
}
