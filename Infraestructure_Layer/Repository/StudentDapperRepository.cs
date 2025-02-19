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
using Microsoft.Data.Sqlite;
using Microsoft.Extensions.Configuration;
using Dapper;
using Microsoft.AspNetCore.Hosting;

namespace Infraestructure_Layer.Repository
{
    public class StudentDapperRepository(IConfiguration _configuration) : IDapperStudentRepository
    {
        //Made With Dapper
              
        public async Task<IEnumerable<StudentModel>> GetAll()
        {
                using var _connection = new SqliteConnection(_configuration.GetConnectionString("DBConnection"));
                var slqQuery = "select Id as IdToString, Name, LastName, Age  from Students";
                var students = await _connection.QueryAsync<StudentModel>(slqQuery);

                return students;         
        }

        public async Task<StudentModel?> GetById(Guid id)
        {
            using var _connection = new SqliteConnection(_configuration.GetConnectionString("DBConnection"));
            var sql = "SELECT Id as IdToString, Name, LastName, Age FROM Students as st where st.Id=@Id";
            var result=await _connection.QueryFirstOrDefaultAsync<StudentModel>(sql, new {Id=id});
            
            return result;
        }

        public IQueryable<StudentModel> ExecuteQuery(Expression<Func<StudentModel, bool>> predicate)
        {

            using var _connection = new SqliteConnection(_configuration.GetConnectionString("DBConnection"));
            var slqQuery = "select Id as IdToString, Name, LastName, Age from Students";
            var students = _connection.Query<StudentModel>(slqQuery);
            return students.AsQueryable().Where(predicate);

        }


    }
}
