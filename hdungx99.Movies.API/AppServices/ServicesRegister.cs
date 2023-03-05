
using hdungx99.Core.Auth.AuthRegister;

namespace hdungx99.Movies.API
{
    public static class ServicesRegister
    {
        public static void AddServices(this IServiceCollection services)
        {
            services.AddAuthAPIServices("hdungx99.moviesAPI");
            services.AddControllers();
            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
        }
    }
}
