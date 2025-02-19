using Application_Layer.Interfaces;
using Application_Layer.Students.Queries.GetStudentById;
using Domain_Layer.Errors;
using Domain_Layer.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Students.Commands.Delete
{
    public sealed class DeleteStudentCommandHandler(IEFCoreStudentRepository _efCoreRepository, IDapperStudentRepository _dapperRepository) : ICommandHandler<DeleteStudentCommand, int>
    {
        public async Task<CustomResult<int>> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
        {
           
            var student = await _dapperRepository.GetById(request.Id);

            if (student is null)
            {
                return CustomResult<int>.Failure(StudentErrors.NotFoundStudent);
            }

            var result=await _efCoreRepository.Delete(request.Id);

            if (result == 0) {
                CustomResult<int>.Failure(StudentErrors.StudentDeleteError);
            }

            return CustomResult<int>.Success(result);
        }
    }
}
