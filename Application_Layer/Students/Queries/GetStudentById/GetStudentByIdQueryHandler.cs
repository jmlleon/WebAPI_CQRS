﻿using Application_Layer.Interfaces;
using Application_Layer.Mapper;
using Domain_Layer.Errors;
using Domain_Layer.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Students.Queries.GetStudentById
{
    internal sealed class GetStudentByIdQueryHandler(IDapperStudentRepository _dapperRepository) : IQueryHandler<GetStudentByIdQuery, StudentResponse>
    {
        public async Task<CustomResult<StudentResponse>> Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
        {
            var result = await _dapperRepository.GetById(request.Id);

            if (result is null) {
                return CustomResult<StudentResponse>.Failure(StudentErrors.NotFoundStudent);            
            }

            return CustomResult<StudentResponse>.Success(result.MapStudentToResponse());
        }
    }
}
