using Application_Layer.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Students.Commands.CreateStudentCommand
{
    public sealed record CreateStudentCommand(string Name,string LastName,int Age):ICommand<int>;    
    
}
