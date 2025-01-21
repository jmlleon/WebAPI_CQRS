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

            //Return student Id

            return await _context.SaveChangesAsync();
        }

        public async Task<int> Delete(Guid id)
        {
            var student=_context.Students.FirstOrDefault(x => x.Id == id);

            if (student == null) { return 0;}

            _context.Students.Remove(student);

            return await _context.SaveChangesAsync(); 
        }

        public IQueryable<StudentModel> ExecuteQuery(Expression<Func<StudentModel, bool>> predicate)
        {
            var result= _context.Students.Select(x => x.MapStudentToModel()).Where(predicate);

            return result;
        }

        public async Task<IEnumerable<StudentModel>> GetAll()
        {
            return await _context.Students.AsNoTracking().Select(s=>s.MapStudentToModel()).ToListAsync();
        }

        public async Task<StudentModel?> GetById(Guid id)
        {
            var student = await _context.Students.FirstOrDefaultAsync(s => s.Id == id);

            return student!=null ? student.MapStudentToModel():null;
        }

        public async Task<int> Update(StudentModel model)
        {
            var student=model.MapModelToStudent();

            _context.Students.Update(student);

           return await _context.SaveChangesAsync();
        }
    }
}
