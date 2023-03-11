using hdungx99.Movies.BLL.IServices;
using hdungx99.Movies.BLL.Model;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace hdungx99.Movies.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _service;
        public CategoryController(ICategoryService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<IEnumerable<CategoryMD>> GetAll()
        {
            return await _service.GetAll();
        }


        [HttpGet("Id")]
        public async Task<CategoryMD> GetById(Guid Id)
        {
            return await (_service.GetById(Id));
        }

        [HttpPost]
        public async Task Post([FromBody] CategoryMD Category)
        {
            await _service.Insert(Category);
        }

        [HttpPut]
        public async Task Put([FromBody] CategoryMD Category)
        {
            await _service.Update(Category);
        }

        [HttpDelete]
        public async void Delete(Guid Id)
        {
            await _service.Delete(Id);
        }
    }
}
