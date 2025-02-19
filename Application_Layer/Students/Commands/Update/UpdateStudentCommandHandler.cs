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
    public sealed class UpdateStudentCommandHandler(IEFCoreStudentRepository _efCoreRepository) : ICommandHandler<UpdateStudentCommand, int>
    {
        public async Task<CustomResult<int>> Handle(UpdateStudentCommand request, CancellationToken cancellationToken)
        {
            //Validation Rules

            var validationResult = StudentValidator.ValidateStudentOnUpdate(request.UrlId, request.MapUpdateToStudent());

            if (validationResult != ValidationResult.Success) {
                return CustomResult<int>.Failure(StudentErrors.ValidationStudentError(validationResult.ErrorMessage ?? ""));            
            }           

            var result = await _efCoreRepository.Update(request.MapUpdateToStudent());

            if (result == 0) {
                return CustomResult<int>.Failure(StudentErrors.StudentUpdateError);                            
            }

            return CustomResult<int>.Success(result);
        }
    }
}
