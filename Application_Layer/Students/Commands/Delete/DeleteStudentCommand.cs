using Application_Layer.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Students.Commands.Delete
{
    public sealed class DeleteStudentCommand(Guid id):ICommand<int>
    {
        public Guid Id { get; set; } = id;
    }
}
