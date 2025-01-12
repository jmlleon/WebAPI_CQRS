using Domain_Layer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Interfaces.Repository
{
    public interface IRepository<T> where T : BaseModel
    {
        public Task<IEnumerable<T>> GetAll();
        public Task<T> GetById(int id);
        public Task<int> Add(T entity);
        public Task<int> Update(T entity);
        public Task<int> Delete(int id);

    }
}
