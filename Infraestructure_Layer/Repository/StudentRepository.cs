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

namespace Infraestructure_Layer.Repository
{
    public class StudentRepository(StudentDbContext _context) : IStudentRepository
    {        

        public async  Task<int> Add(StudentModel model)
        {
            _context.Students.Add(model.MapModelToStudent());

            return await _context.SaveChangesAsync();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<StudentModel>> ExecuteQuery(Expression<Func<StudentModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<StudentModel>> GetAll()
        {
            return await _context.Students.AsNoTracking().Select(s=>s.MapStudentToModel()).ToListAsync();
        }

        public Task<StudentModel> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(StudentModel entity)
        {
            throw new NotImplementedException();
        }
    }
}
