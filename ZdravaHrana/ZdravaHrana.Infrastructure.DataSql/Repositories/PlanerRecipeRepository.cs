using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZdravaHrana.Domain.Entities;
using ZdravaHrana.Domain.Entities.Interfaces;
using ZdravaHrana.Infrastructure.DataSql.DataAccess;

namespace ZdravaHrana.Infrastructure.DataSql.Repositories
{
    public class PlanerRecipeRepository : IPlanerRecipeRepository
    {
        DatabaseContext db = new DatabaseContext();
        public List<PlanerRecipe> getAllPlanerRecipe()
        {
            List<PlanerRecipe> planerRecipe = new List<PlanerRecipe>();
            var items = db.PlanerRecipe.AsEnumerable();
            foreach (var item in items)
            {
                var vm = new PlanerRecipe();
                vm.id = item.id;
                vm.planerDayId = item.planerDayId;
                vm.planerMealTimePosition = item.planerMealTimePosition;
                vm.planerMealTime = item.planerMealTime;
                vm.planerId = item.planerId;
                vm.recipeId = item.recipeId;
                planerRecipe.Add(vm);

            }
            return planerRecipe;
        }
    }
}
