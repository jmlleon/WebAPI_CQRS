using Domain_Layer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Interfaces.Repository
{
    public interface IEFCoreRepository<T> where T : BaseModel
    {        
       
        public Task<string> Add(T entity);
        public Task<int> Update(T entity);
        public Task<int> Delete(Guid id);

    }
}
