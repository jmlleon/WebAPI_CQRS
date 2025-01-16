using Domain_Layer.Interfaces.Repository;
using Infraestructure_Layer.InMemoryDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

using Domain_Layer.Model;
using Infraestructure_Layer.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infraestructure_Layer.Repository
{
    public class StudentRepository : IStudentRepository
    {
        private readonly StudentDbContext _context;
        public StudentRepository(StudentDbContext context)
        {
            _context = context;               
        }


        public Task<int> Add(Domain_Layer.Model.Student entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IQueryable<Domain_Layer.Model.Student>> ExecuteQuery(Expression<Func<Domain_Layer.Model.Student, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Domain_Layer.Model.Student>> GetAll()
        {
            return await _context.Students.AsNoTracking().Select(s=>new Domain_Layer.Model.Student(s.Id, s.Name,s.LastName,s.Age)).ToListAsync();
        }

        public Task<Domain_Layer.Model.Student> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Domain_Layer.Model.Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
