using Application_Layer.Interfaces;
using Application_Layer.Mapper;
using Application_Layer.Students.Queries.GetStudentById;
using Domain_Layer.Errors;
using Domain_Layer.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Students.Queries.GetAll
{
    public sealed class GetAllStudentsQueryHandler : IQueryHandler<GetAllStudentsQuery, IEnumerable<StudentResponse>>
    {
        private readonly IStudentRepository _studentRepository;

        public GetAllStudentsQueryHandler(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task<CustomResult<IEnumerable<StudentResponse>>> Handle(GetAllStudentsQuery request, CancellationToken cancellationToken)
        {
            var result= await _studentRepository.GetAll();

            return CustomResult<IEnumerable<StudentResponse>>.Success(result.Select(s => s.StudentToResponse()));

        }
    }
}
