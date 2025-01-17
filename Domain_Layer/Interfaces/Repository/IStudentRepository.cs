using Domain_Layer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Interfaces.Repository
{
    public interface IStudentRepository:IRepository<StudentModel>
    {
       public Task<IQueryable<StudentModel>> ExecuteQuery(Expression<Func<StudentModel, bool>> predicate);
    }
}
