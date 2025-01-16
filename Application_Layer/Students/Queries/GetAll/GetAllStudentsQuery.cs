using Application_Layer.Interfaces;
using Application_Layer.Students.Queries.GetStudentById;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Students.Queries.GetAll
{
    public record GetAllStudentsQuery:IQuery<IEnumerable<StudentResponse>>
    {
    }
}
