using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using ZdravaHrana.Domain.Entities.Interfaces;
using ZdravaHrana.Infrastructure.DataSql.Repositories;

namespace ZdravaHrana.Controllers
{
    public class IngredientsController : ApiController
    {
        IIngredientRepository _ingredientRepository;

        [HttpGet]
        [ResponseType(typeof(List<Ingredients>))]
        [ActionName("ingredients")]
        public HttpResponseMessage GetAllIngredients(string name = "")
        {
            _ingredientRepository = new IngredientsRepository();

            IEnumerable<Ingredients> ingredient = new List<Ingredients>();

            if (!string.IsNullOrWhiteSpace(name))
                ingredient = _ingredientRepository.getAllIngredients()
                    .Where(x => x.ingredient.ToLower().Contains(name.ToLower()))
                    .ToList();
            else
                ingredient= _ingredientRepository.getAllIngredients().ToList();

            return Request.CreateResponse(HttpStatusCode.OK, ingredient);

        }
    }
}