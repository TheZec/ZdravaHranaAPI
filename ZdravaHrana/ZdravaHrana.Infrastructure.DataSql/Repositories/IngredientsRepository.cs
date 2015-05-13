using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZdravaHrana.Domain.Entities.Interfaces;
using ZdravaHrana.Infrastructure.DataSql.DataAccess;

namespace ZdravaHrana.Infrastructure.DataSql.Repositories
{
    public class IngredientsRepository : IIngredientRepository
    {
        DatabaseContext db = new DatabaseContext();
        public List<Ingredients> getAllIngredients()
        {
            List<Ingredients> ingredients = new List<Ingredients>();
            var items = db.Ingredients.AsEnumerable();
            foreach (var item in items)
            {
                var vm = new Ingredients();
                vm.id = item.id;
                vm.ingredient= item.ingredient;
                vm.recipe_Id = item.recipe_Id;
                ingredients.Add(vm);
            }
            return ingredients;
        }
    }
}