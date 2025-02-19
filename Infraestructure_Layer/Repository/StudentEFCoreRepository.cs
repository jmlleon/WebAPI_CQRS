using Domain_Layer.Interfaces.Repository;
using Infraestructure_Layer.InMemoryDB;
using Infraestructure_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Domain_Layer.Model;

using Microsoft.EntityFrameworkCore;
using Infraestructure_Layer.Mapper;
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using Dapper;

namespace Infraestructure_Layer.Repository
{
    public class StudentEFCoreRepository(StudentDbContext _context) : IEFCoreStudentRepository
    {        

        public async  Task<string> Add(StudentModel model)
        {
            _context.Students.Add(model.MapModelToStudent());
          
           await _context.SaveChangesAsync();

           return model.IdToString;
        }

        public async Task<int> Delete(Guid id)
        {
            var student=_context.Students.FirstOrDefault(x => x.Id == id);

            if (student is null) { return 0;}

            _context.Students.Remove(student);

            return await _context.SaveChangesAsync(); 
        }

        public async Task<int> Update(StudentModel model)
        {
            _context.Students.Update(model.MapModelToStudent());

            return await _context.SaveChangesAsync();
        }        


    }
}
