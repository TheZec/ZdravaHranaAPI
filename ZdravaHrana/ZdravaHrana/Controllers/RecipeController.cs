using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ZdravaHrana.Domain.Entities;
using ZdravaHrana.Domain.Entities.Interfaces;
using ZdravaHrana.Infrastructure.DataSql.Repositories;

namespace ZdravaHrana.Controllers
{
    public class RecipeController : ApiController
    {
        IRecipeRepository _recipeRepository;

        [HttpGet]
        [ResponseType(typeof(List<Recipe>))]
        [ActionName("recipe")]
        public HttpResponseMessage GetAllRecipes(string name = "")
        {
            _recipeRepository = new RecipeRepository();

            IEnumerable<Recipe> recipe = new List<Recipe>();

            if (!string.IsNullOrWhiteSpace(name))
                recipe = _recipeRepository.getAllRecipes()
                    .Where(x => x.recipeName.ToLower().Contains(name.ToLower()))
                    .ToList();
            else
                recipe = _recipeRepository.getAllRecipes().ToList();

            return Request.CreateResponse(HttpStatusCode.OK, recipe);
         
        }
    }
}
