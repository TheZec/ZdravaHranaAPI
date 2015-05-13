using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZdravaHrana.Domain.Entities
{
    public class Recipe
    {

        public int id { get; set; }
        public string recipeName { get; set; }
        public string imageUrl { get; set; }
        public string preparation { get; set; }
        public int month { get; set; }
        public bool isFreez { get; set; }
        public int timeOfPreparation { get; set; }
        public int timeOfCook { get; set; }
       
    }
}
