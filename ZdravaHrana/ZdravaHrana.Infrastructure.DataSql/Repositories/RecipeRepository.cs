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
    public class RecipeRepository : IRecipeRepository
    {
        DatabaseContext db = new DatabaseContext();
        public List<Recipe> getAllRecipes()
        {
            if (db.Planer.ToList() != null)
            {
                return db.Recipe.ToList();
            }
            else
            {
                return null;
            }
        }
    }
}