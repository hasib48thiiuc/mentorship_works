using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FWork
{
    public class TrainingDbContext : DbContext
    {
        private string _assemblyName;
        private string _connectionString;

        public DbSet<Student> Main2Students { get; set; }
        public DbSet<Course> Courses { get; set; }

        public TrainingDbContext()
        {
            _connectionString = "Server =DESKTOP-M6I5G2C\\SQLEXPRESS; Database =MainDb; User Id=hasib; Password = 999111;TrustServerCertificate=True;";
            _assemblyName = Assembly.GetExecutingAssembly().FullName;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(_connectionString, m => m.MigrationsAssembly(_assemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Topic>().ToTable("Topics");

            builder.Entity<CourseStudent>().ToTable("CourseStudents");

            builder.Entity<CourseStudent>().HasKey(cs => new { cs.CourseId, cs.StudentId });

            builder.Entity<Course>().
                HasMany(p => p.Topics).WithOne
                (i => i.course);

            builder.Entity<CourseStudent>().
                HasOne(a => a.course).
                WithMany(b => b.Students).
                HasForeignKey(c => c.CourseId);

            builder.Entity<CourseStudent>().
                HasOne(x => x.student).WithMany
                (y => y.Courses).HasForeignKey(pc => pc.StudentId);

            base.OnModelCreating(builder);

        }





    }
}