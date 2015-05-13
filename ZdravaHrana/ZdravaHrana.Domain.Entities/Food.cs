using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZdravaHrana.Domain.Entities
{
    public class Food
    {
        public int id { get; set; }
        public string type { get; set; }
        public string foodName { get; set; }
        public string description { get; set; }
    }
}
