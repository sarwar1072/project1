using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
namespace Assignment6.Library.Framework
{
   public class FrameworkContext: DbContext, IFrameworkContext
    {
        private string _connectionString;
        private string _migrationAssemblyName;

        public FrameworkContext(string connectionString, string migrationAssemblyName)
        {
            _connectionString = connectionString;
            _migrationAssemblyName = migrationAssemblyName;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            if (!dbContextOptionsBuilder.IsConfigured)
            {
                dbContextOptionsBuilder.UseSqlServer(
                    _connectionString,
                    m => m.MigrationsAssembly(_migrationAssemblyName));
            }

            base.OnConfiguring(dbContextOptionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            // Many to many relation
            builder.Entity<StudentRegistration>()
                .HasKey(pc => new { pc.StudentId, pc.CourseId });

            builder.Entity<StudentRegistration>()
                .HasOne(pc => pc.Student)
                .WithMany(p => p.Registration)
                .HasForeignKey(c => c.StudentId);


            builder.Entity<StudentRegistration>()
                .HasOne(pc => pc.Course)
                .WithMany(c => c.Registration)
                .HasForeignKey(p => p.CourseId);

            base.OnModelCreating(builder);
        }

        public DbSet<Student> Student { get; set; }
        public DbSet<Course> Course { get; set; }
        //public DbSet<StudentRegistration> Registration { get; set; }
    }
}
