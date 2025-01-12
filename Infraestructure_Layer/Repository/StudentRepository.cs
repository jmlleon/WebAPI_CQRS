using Domain_Layer.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure_Layer.Repository
{
    internal class StudentRepository : IRepository<Student>
    {
        public Task<int> Add(Student entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Student>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Student> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(Student entity)
        {
            throw new NotImplementedException();
        }
    }
}
