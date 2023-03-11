using AutoMapper;
using hdungx99.Core.EF.Repository;
using hdungx99.Movies.BLL.IServices;
using hdungx99.Movies.BLL.Model;
using hdungx99.Movies.DAL.Context;
using hdungx99.Movies.DAL.Entity;

namespace hdungx99.Movies.BLL.Services
{
    public class CategoryService : GenericRepository<Category, CategoryMD>, ICategoryService
    {

        public CategoryService(MoviesContext context, IMapper mapper) : base(context, mapper)
        {
        }
    }
}
