using Domain_Layer.Interfaces.Repository;
using Infraestructure_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure_Layer.Repository
{
    public class StudentRepository : IStudentRepository
    {
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

        public Task<IEnumerable<Domain_Layer.Model.Student>> GetAll()
        {
            throw new NotImplementedException();
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
