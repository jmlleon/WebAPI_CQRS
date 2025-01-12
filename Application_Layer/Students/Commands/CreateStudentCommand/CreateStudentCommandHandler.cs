using Application_Layer.Interfaces;
using Domain_Layer.Errors;
using Domain_Layer.Interfaces.Repository;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Students.Commands.CreateStudentCommand
{
    internal sealed class CreateStudentCommandHandler : ICommandHandler<CreateStudentCommand,int>
    {

        private readonly IStudentRepository _studentRepository;

        public CreateStudentCommandHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository; 
            
        }

        public Task<CustomResult<int>> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}

