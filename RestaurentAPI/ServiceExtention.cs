using Infrastructure;
using Microsoft.EntityFrameworkCore;
using Repository;

namespace RestaurentAPI
{
    public static  class ServiceExtention
    {

        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy",
                    builder => builder.AllowAnyOrigin()
                    .AllowAnyMethod()
                    .AllowAnyHeader());
            });
        }

        public static void ConfigureLoggerService(this IServiceCollection services)
        {
           // services.AddSingleton<ILoggerManager, LoggerManager>();
        }
        public static void ConfigureSqliteContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config["ConnectionStrings:WebApiDatabase"];

            services.AddDbContext<RestaurentDbContext>(o => o.UseSqlite(connectionString));
        }

        public static void ConfigureRepositoryWrapper(this IServiceCollection services)
        {
            services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();
        }
    }
}
