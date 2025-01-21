using Application_Layer.Interfaces;
using Domain_Layer.Errors;
using Domain_Layer.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Students.Commands.Delete
{
    public sealed class DeleteStudentCommandHandler(IStudentRepository _repository) : ICommandHandler<DeleteStudentCommand, int>
    {
        public async Task<CustomResult<int>> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
            //Validate student Id

            var result=await _repository.Delete(request.Id);

            if (result == 0) {
                CustomResult<int>.Failure(StudentErrors.StudentDeleteError);
            }

            return CustomResult<int>.Success(result);
        }
    }
}
