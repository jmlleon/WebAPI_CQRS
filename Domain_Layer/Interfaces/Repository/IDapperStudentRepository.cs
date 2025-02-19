using Domain_Layer.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Interfaces.Repository
{
    public interface IDapperStudentRepository:IDapperRepository<StudentModel>
    {
       public IQueryable<StudentModel> ExecuteQuery(Expression<Func<StudentModel, bool>> predicate);
    }
}
