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
    public class PlanerRecipeController : ApiController
    {
        IPlanerRecipeRepository _planerRecipeRepository;

        [HttpGet]
        [ResponseType(typeof(List<PlanerRecipe>))]
        [ActionName("planerRecipe")]
        public HttpResponseMessage GetAllPlanerRecipe(string name = "")
        {
            _planerRecipeRepository = new PlanerRecipeRepository();

            IEnumerable<PlanerRecipe> planerRecipe= new List<PlanerRecipe>();

            if (!string.IsNullOrWhiteSpace(name))
                planerRecipe = _planerRecipeRepository.getAllPlanerRecipe()
                    .Where(x => x.planerMealTime.ToLower().Contains(name.ToLower()))
                    .ToList();
            else
                planerRecipe = _planerRecipeRepository.getAllPlanerRecipe().ToList();

            return Request.CreateResponse(HttpStatusCode.OK, planerRecipe);
        }
    }
}
