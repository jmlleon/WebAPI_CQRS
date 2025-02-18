
using Infraestructure_Layer.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Dapper.SqlMapper;

namespace Infraestructure_Layer.InMemoryDB
{
    public class StudentDbContext:DbContext
    {

        IConfiguration _configuration;

        public StudentDbContext(DbContextOptions<StudentDbContext> options, IConfiguration configuration)
        : base(options)
        {
            //Database.EnsureCreated();
            _configuration = configuration;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           
            modelBuilder.Entity<Student>(entity =>
            {

                entity.HasKey(x => x.Id);
                //entity.Property(e => e.Id).HasColumnType("VARCHAR");
                entity.Property(e => e.Name).HasColumnType("VARCHAR");
                entity.Property(e => e.LastName).HasColumnType("VARCHAR");
                entity.Property(e => e.Age).HasColumnType("INTEGER");
                entity.HasData(
                new Student(new Guid("7fb65126-a34f-4834-b5ea-b84e8ebc5b99"), "Juan Miguel", "Lorenzo Leon", 35),
                new Student(new Guid("a25b788d-2396-4927-870e-bbe5cd70b1da"), "Pedro Luis", "Gonzalez Gutierrez", 36)
                );

            });

            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // optionsBuilder.UseInMemoryDatabase(databaseName: "StudentDb");

            //"DataSource=.\\Database\\products.db"
            //, b => b.MigrationsAssembly("WebAPI_CQRS")

            //"Data Source=../YOUR_PROJECT.Infrastructure/data.sqlite"

            optionsBuilder.UseSqlite(_configuration.GetConnectionString("DBConnection"));
        }

        public DbSet<Student> Students { get; set; }
      
    }
}
