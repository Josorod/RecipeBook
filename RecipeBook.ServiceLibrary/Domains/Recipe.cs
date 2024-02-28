using RecipeBook.ServiceLibrary.Models;
using RecipeBook.ServiceLibrary.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeBook.ServiceLibrary.Domains
{
    public class Recipe
    {
        
        public void SaveRecipe(RecipeModel recipeModel)
        {
            // Validate data

            var repository = new RecipeRepository();
            repository.SaveRecipeToDatabase(recipeModel);
        }
    }
}
