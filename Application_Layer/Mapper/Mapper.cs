using Application_Layer.Students.Commands.Create;
using Application_Layer.Students.Commands.Update;
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
        public static StudentResponse MapStudentToResponse(this StudentModel student) {         
        
            return new StudentResponse(student.Name, student.LastName, student.Age);        
        }

       /* public static StudentModel MapResponseToStudent(this StudentResponse studentResponse) {        
        
        return new StudentModel(studentResponse.Name, studentResponse.LastName, studentResponse.Age); 
        
        }*/

        public static StudentModel MapCreateToStudent(this CreateStudentCommand createCommand)
        {
            return new StudentModel(Guid.NewGuid(), createCommand.Name, createCommand.LastName, createCommand.Age);

        }

        public static UpdateStudentModel MapUpdateToStudent(this UpdateStudentCommand updateCommand)
        {
            return new UpdateStudentModel(updateCommand.Id, updateCommand.Name, updateCommand.LastName, updateCommand.Age);

        }


    }
}
