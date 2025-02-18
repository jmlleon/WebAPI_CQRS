using Application_Layer.Interfaces;
using Application_Layer.Mapper;
using Application_Layer.Validation;
using Domain_Layer.Errors;
using Domain_Layer.Interfaces.Repository;
using Domain_Layer.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Students.Commands.Update
{
    public sealed class UpdateStudentCommandHandler(IEFCoreStudentRepository _repository) : ICommandHandler<UpdateStudentCommand, int>
    {
        public async Task<CustomResult<int>> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            //Validation 

            var validationResult = StudentValidator.ValidateStudentOnUpdate(request.UrlId, request.MapUpdateToStudent());

            if (validationResult != ValidationResult.Success) {
                return CustomResult<int>.Failure(StudentErrors.ValidationStudentError(validationResult.ErrorMessage ?? ""));            
            }

            var student = new StudentModel(request.Id, request.Name, request.LastName, request.Age);

            var result = await _repository.Update(student);

            if (result == 0) {
                return CustomResult<int>.Failure(StudentErrors.StudentDeleteError);                            
            }

            return CustomResult<int>.Success(result);
        }
    }
}
