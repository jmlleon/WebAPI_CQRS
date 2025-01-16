using Application_Layer.Interfaces;
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

namespace Application_Layer.Students.Commands.CreateStudentCommand
{
    internal sealed class CreateStudentCommandHandler(IStudentRepository _studentRepository) : ICommandHandler<CreateStudentCommand,int>
    {

        public async Task<CustomResult<int>> Handle(CreateStudentCommand request, CancellationToken cancellationToken)
        {
            //Make Validation Rules

            var validationResult = StudentValidator.ValidateStudent((new Student(request.Name, request.LastName, request.Age)));

            if (validationResult != ValidationResult.Success) {

                return CustomResult<int>.Failure(CustomError.ValidationError(validationResult.ErrorMessage ?? ""));
            
            }

            var result = await _studentRepository.Add(new Student(request.Name, request.LastName, request.Age));


            return result > 0 ? CustomResult<int>.Success(result):CustomResult<int>.Failure(CustomError.)


        }
    }
}

