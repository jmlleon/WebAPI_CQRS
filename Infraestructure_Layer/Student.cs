using Domain_Layer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure_Layer
{
    internal class Student:BaseEntity
    {

        public int Id { get; set; }
        public string Name { get; set; }=String.Empty;
        public int Age { get; set; }
    }
}
