using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PokemonReview.Repository;

namespace PokemonReview.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly CategoryRepository _categoryRepository;

        public CategoriesController(CategoryRepository categoryRepository) 
        {
            _categoryRepository = categoryRepository;
        }
        [HttpGet]
        [ProducesResponseType(200)]
        
    }
}
