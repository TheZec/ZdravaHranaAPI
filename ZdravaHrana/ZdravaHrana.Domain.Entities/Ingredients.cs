using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZdravaHrana.Domain.Entities.Interfaces
{
   public class Ingredients
    {
       public int id { get; set; }
       public string ingredient { get; set; }
       public int recipe_Id { get; set; }
       public virtual Recipe recipe { get; set; }
    }
}
