
using Infraestructure_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure_Layer.InMemoryDB
{
    public class StudentDbContext:DbContext
    {

        public StudentDbContext(DbContextOptions<StudentDbContext> options)
        : base(options)
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder); 

            modelBuilder.Entity<Student>().HasKey(x => x.Id);
            modelBuilder.Entity<Student>().HasData(
                new Student(Guid.NewGuid(), "Juan Miguel", "Lorenzo Leon", 35),
                new Student(Guid.NewGuid(), "Pedro Luis", "Gonzalez Gutierrez", 36)
                );
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase(databaseName: "StudentDb");
        }

        public DbSet<Student> Students { get; set; }
      
    }
}
