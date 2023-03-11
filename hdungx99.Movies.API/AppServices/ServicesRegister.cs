
using hdungx99.Core.Auth.AuthRegister;
using hdungx99.Movies.BLL.IServices;
using hdungx99.Movies.BLL.Services;
using hdungx99.Movies.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace hdungx99.Movies.API
{
    public static class ServicesRegister
    {
        public static void AddServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddAuthAPIServices("hdungx99.moviesAPI");
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddAutoMapper(Assembly.GetExecutingAssembly());
            services.AddDbContextPool<MoviesContext>(options => options.UseSqlServer(config.GetConnectionString("hdungx99.Movies")));
        }
        public static void AddDIServices(this IServiceCollection services)
        {
            services.AddTransient<ICategoryService, CategoryService>();
        }

    }
}
