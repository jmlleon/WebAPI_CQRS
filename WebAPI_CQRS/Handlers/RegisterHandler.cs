using Application_Layer.Students.Queries.GetAll;

namespace WebAPI_CQRS.Handlers
{
    public static class RegisterHandler
    {

        public static void RegisterMediatRHandlers(this WebApplicationBuilder builder) {

            // Add services to the container.

            //builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssemblyContaining<Startup>());
            //RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            //typeof(AssemblyReference)
            //builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(Program).Assembly));

            //builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(Assembly.GetExecutingAssembly()));

            builder.Services.AddMediatR(cfg => cfg.RegisterServicesFromAssembly(typeof(GetAllStudentsQueryHandler).Assembly));


        }

    }
}
