using Application_Layer.Interfaces;
using Domain_Layer.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application_Layer.Services
{
    public class StudentService : IService<StudentDTO>
    {
        

        public Task<int> Add(StudentDTO entity)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<StudentDTO>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<StudentDTO> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<int> Update(StudentDTO entity)
        {
            throw new NotImplementedException();
        }
    }
}
