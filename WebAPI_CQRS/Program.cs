using Application_Layer.Students.Queries.GetAll;
using Domain_Layer.Interfaces.Repository;
using Infraestructure_Layer.Entities;
using Infraestructure_Layer.InMemoryDB;
using Infraestructure_Layer.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using System.Reflection.Metadata;
using WebAPI_CQRS.Handlers;

var builder = WebApplication.CreateBuilder(args);

builder.RegisterMediatRHandlers();

builder.Services.AddDbContext<StudentDbContext>();

//options => { options.UseInMemoryDatabase("StudentDb"); options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);}

builder.Services.AddScoped<IStudentRepository, StudentRepository>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

/*using (var scope = app.Services.CreateScope())
{
    var dbInitializer = scope.ServiceProvider.GetRequiredService<IDbInitializer>();
    dbInitializer.Initialize();
}*/

/*using (var scope = app.Services.CreateScope())
{

    using (var contextValue = scope.ServiceProvider.GetRequiredService<StudentDbContext>())
    {

        contextValue.Database.EnsureCreated();

        List<Student> students =
           [
               new Student { Id = 1, Name = "Juan Miguel ", LastName = "Lorenzo", Age = 35 },
               new Student { Id = 1, Name = "Pedro Luis", LastName = "Gonzalez", Age = 36 },
           ];

        contextValue.AddRange(students);
        contextValue.SaveChanges();
    }

    //someContext.Seed();

}*/

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
