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
    public class FoodController : ApiController
    {
        IFoodRepository _foodRepository;

        [HttpGet]
        [ResponseType(typeof(List<Food>))]
        [ActionName("food")]
        public HttpResponseMessage GetAllFoods(string name = "")
        {
            _foodRepository = new FoodRepository();

            List<Food> food = new List<Food>();

            if (!string.IsNullOrWhiteSpace(name))
                food = _foodRepository.getAllFoods()
                    .Where(x => x.foodName.ToLower().Contains(name.ToLower()))
                    .ToList();
            else
                food = _foodRepository.getAllFoods().ToList();

            return Request.CreateResponse(HttpStatusCode.OK, food);
        }
    }
}
