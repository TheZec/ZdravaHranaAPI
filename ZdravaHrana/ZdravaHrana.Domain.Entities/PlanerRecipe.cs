using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZdravaHrana.Domain.Entities
{
    public class PlanerRecipe
    {
        public int id { get; set; }
        public string planerMealTime { get; set; }
        public int planerMealTimePosition { get; set; }
        public int planerDayId { get; set; }
        public int planerId { get; set; }
        public int recipeId { get; set; }
        public virtual Planer planer { get; set; }
        public virtual Recipe recipe { get; set; }
    }
}
