using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Layer.DTO;

namespace Application_Layer.Interfaces
{
    internal interface IService<T> where T : BaseDTO
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> GetById(int id);
        public Task<int> Add(T entity);
        public Task<int> Update(T entity);
        public Task Delete(int id);

    }
}
