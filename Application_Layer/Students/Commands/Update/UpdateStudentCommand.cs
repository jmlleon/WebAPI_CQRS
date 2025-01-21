using Application_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Application_Layer.Students.Commands.Update
{
    public sealed class UpdateStudentCommand(Guid Id, string Name, string LastName, int Age, Guid UrlId) :ICommand<int>
    {
        public Guid Id { get; set; } = Id;
        public string Name { get; set; } = Name;
        public string LastName { get; set; } = LastName;
        public int Age { get; set; } = Age;
        public Guid UrlId { get; set; } = UrlId;
    }
}
