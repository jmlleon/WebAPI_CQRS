using Application_Layer.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Application_Layer.Students.Commands.Create
{
    public sealed class CreateStudentCommand(string Name, string LastName, int Age) : ICommand<int> {

        public string Name { get; set; } = Name;
        public string LastName { get; set; } = LastName;
        public int Age { get; set; } = Age;


    }
    
}
