using TO_DO.Application.SubTask;
using TO_DO.Application.TO_DO;
using TO_DO.Application.User;
using TO_DO.Infrastructure.SubTasks;
using TO_DO.Infrastructure.TO_DOs;
using TO_DO.Infrastructure.User;

namespace TO_DO.API.Infrastructure.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddServices(this IServiceCollection services) {

            services.AddScoped<IUserService, UserService>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddScoped<ISubTaskService, SubTaskService>();
            services.AddScoped<ISubTaskRepository, SubTaskRepository>();

            services.AddScoped<ITO_DOService, TO_DOService>();
            services.AddScoped<ITO_DORepository, TO_DORepository>();
        }
    }
}
