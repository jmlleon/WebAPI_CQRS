using Domain_Layer.Model;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure_Layer.Entities
{
    public sealed class Student(Guid id, string name, string lastName, int age) : BaseEntity
    {
        public Guid Id { get; set; } = id;
        public string Name { get; set; } = name;
        public string LastName { get; set; } = lastName;
        public int Age { get; set; } = age;
    }
}
