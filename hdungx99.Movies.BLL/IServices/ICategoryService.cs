using hdungx99.Core.EF.IRepository;
using hdungx99.Movies.BLL.Model;
using hdungx99.Movies.DAL.Entity;

namespace hdungx99.Movies.BLL.IServices
{
    public interface ICategoryService : IGenericRepository<Category, CategoryMD>
    {
    }
}
