using Domain_Layer.Model;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure_Layer.Entities
{
    public sealed class Student : BaseEntity
    {
        
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }

        public Student(int id, string name, string lastName, int age)
        {
            Id = id;
            Name = name;
            LastName= lastName;
            Age = age;
            
        }
    }
}
