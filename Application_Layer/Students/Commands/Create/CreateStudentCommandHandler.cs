using Application_Layer.Interfaces;
using Application_Layer.Mapper;
using Application_Layer.Validation;
using Domain_Layer.Errors;
using Domain_Layer.Interfaces.Repository;
using Domain_Layer.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Students.Commands.Create
{
    internal sealed class CreateStudentCommandHandler(IEFCoreStudentRepository _studentRepository) : ICommandHandler<CreateStudentCommand,Guid>
    {

        public async Task<CustomResult<Guid>> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            //Make Validation Rules

            var validationResult = StudentValidator.ValidateStudent(request.MapCreateToStudent());

            if (validationResult != ValidationResult.Success) {
                return CustomResult<Guid>.Failure(StudentErrors.ValidationStudentError(validationResult.ErrorMessage??""));
             }

            var result = await _studentRepository.Add(request.MapCreateToStudent());

            return !String.IsNullOrEmpty(result) ? CustomResult<Guid>.Success(new Guid(result)) : CustomResult<Guid>.Failure(StudentErrors.StudentAddError);


        }
    }
}

