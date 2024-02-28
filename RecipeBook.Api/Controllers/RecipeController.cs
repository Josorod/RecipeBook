using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RecipeBook.ServiceLibrary.Domains;
using RecipeBook.ServiceLibrary.Models;

namespace RecipeBook.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RecipeController : ControllerBase
    {

        [HttpGet]
        public IActionResult AddNewRecipe(RecipeModel recipeModel)
        {
            var buisnessLogic = new Recipe();
            buisnessLogic.SaveRecipe(recipeModel);

            return Ok();
        }
    }
}
