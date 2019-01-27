using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EFCoreInMemory.Controllers
{
    [Route("api/Category")]
    public class CategoryController : Controller
    {
        private readonly ApiContext apiContext;

        public CategoryController(ApiContext apiContext)
        {
            this.apiContext = apiContext;
        }

        // GET api/values
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            List<Category> categories = apiContext.GetCategories();
            return Ok(categories);
        }
    }
}