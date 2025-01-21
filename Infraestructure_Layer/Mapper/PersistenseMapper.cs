using Domain_Layer.Model;
using Infraestructure_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure_Layer.Mapper
{
    public static class PersistenseMapper
    {

        public static StudentModel MapStudentToModel(this Student student)=>new (student.Id, student.Name, student.LastName, student.Age);

        public static Student MapModelToStudent(this StudentModel model)=> new (model.Id, model.Name, model.LastName, model.Age);
        

    }
}
