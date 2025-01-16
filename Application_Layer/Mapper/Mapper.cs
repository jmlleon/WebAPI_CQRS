using Application_Layer.Students.Queries.GetStudentById;
using Domain_Layer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Mapper
{
    public static class Mapper
    {
        public static StudentResponse StudentToResponse(this Student student) {         
        
            return new StudentResponse(student.Name, student.LastName, student.Age);        
        }
    }
}
