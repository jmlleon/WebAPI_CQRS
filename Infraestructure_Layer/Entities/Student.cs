using Domain_Layer.Model;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Infraestructure_Layer.Entities
{
    public sealed class Student(Guid id, string name, string lastName, int age) : BaseEntity
    {

        public Guid Id { get; set; } = id;
        /* public string Id
         {
             get { return Guid_Id.ToString("N"); }
             set { Guid_Id = new Guid(value); }
         }*/

        // private Guid Guid_Id { get; set; } 
        public string Name { get; set; } = name;
        public string LastName { get; set; } = lastName; 
        public int Age { get; set; }=age;
        

        /*public Student(string id, string name, string lastName, int age)
        {
            Id=id;
            Guid_Id = new Guid(id);
            Name = name;
            LastName = lastName;
            Age = age;

        }*/

        
    }
}
