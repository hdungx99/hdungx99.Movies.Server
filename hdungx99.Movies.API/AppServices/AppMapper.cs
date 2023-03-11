using AutoMapper;
using hdungx99.Movies.BLL.Model;
using hdungx99.Movies.DAL.Entity;

namespace hdungx99.Movies.API.AppServices
{
    public class AppMapper : Profile
    {
        public AppMapper()
        {
            CreateMap<CategoryMD, Category>().ReverseMap();
        }
    }
}
