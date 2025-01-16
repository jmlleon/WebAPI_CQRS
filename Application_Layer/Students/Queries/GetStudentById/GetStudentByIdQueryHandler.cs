using Application_Layer.Interfaces;
using Domain_Layer.Errors;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Students.Queries.GetStudentById
{
    public sealed class GetStudentByIdQueryHandler : IQueryHandler<GetStudentByIdQuery, StudentResponse>
    {
        public Task<CustomResult<StudentResponse>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
