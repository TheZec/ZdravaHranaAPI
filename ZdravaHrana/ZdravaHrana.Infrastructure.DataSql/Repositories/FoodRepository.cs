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
   public class FoodRepository : IFoodRepository
    {
        DatabaseContext db = new DatabaseContext();
        public List<Food> getAllFoods()
        {
            List<Food> food = db.Food.ToList();
            if (food != null)
            {
                return food;
            }
            else
            {
                return null;
            }
        }
    }
}
