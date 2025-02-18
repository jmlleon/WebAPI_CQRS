﻿using Infraestructure_Layer.Entities;
using Infraestructure_Layer.InMemoryDB;
using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure_Layer.Repository
{
          public static class SqlLiteDBCreation {

            //Extension Method to generate Sqlite DB
            /*public static async Task<bool> CreateSqlLiteDBAsync(this WebApplication app)
            {
                string connectionString = app.Configuration.GetConnectionString("SqliteConnection")!;

                var createSQL = @"CREATE TABLE IF NOT EXISTS Student (
            Id INTEGER PRIMARY KEY AUTOINCREMENT,
            Name TEXT,
            Age INTEGER,
            Description TEXT           
        );";

                var insertSQL = @"
           INSERT INTO Student (Name, Age, Description)
           VALUES 
                ('John Michael', '35', 'First Student'),
                ('Silver Stone', '28', 'Second Student'),
                ('Lucas Jonson', '30', 'Third Student');";

                using var connection = new SqliteConnection(connectionString);

                connection.Open();

                using var transaction = connection.BeginTransaction();

                try
                {

                    var studentsTableExists = await connection.QueryFirstOrDefaultAsync<int>(
                       "SELECT COUNT(*) FROM sqlite_master WHERE type='table' AND name='Student';", transaction: transaction);
                   

                    if (studentsTableExists > 0)
                    {
                        return true;
                    }


                    await connection.ExecuteAsync(createSQL, transaction: transaction);

                    await connection.ExecuteAsync(insertSQL, transaction: transaction);

                    transaction.Commit();

                    connection.Close();

                    return true;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);

                    transaction.Rollback();
                    connection.Close();
                    return false;
                }
            }*/

        }
    
}
