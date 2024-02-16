using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        List<Category> listofcategories = new List<Category>() { 
        new Category{Id=1, Title="Samsung",DisplayOder=1},
          new Category{Id=2, Title="Nokia",DisplayOder=2},
            new Category{Id=3, Title="Apple",DisplayOder=3},
              new Category{Id=4, Title="RealMe",DisplayOder=4},
                new Category{Id=5, Title="Oppo",DisplayOder=5},
            };
        [HttpGet]
        public IEnumerable<Category> Get()
        {
            return listofcategories;
        }

    }
}
