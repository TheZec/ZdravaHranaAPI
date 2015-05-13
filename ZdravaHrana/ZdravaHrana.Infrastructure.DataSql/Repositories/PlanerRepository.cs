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
    public class PlanerRepository : IPlanerRepository
    {
        DatabaseContext db = new DatabaseContext();
        public List<Planer> getAllPlaners()
        {
            if (db.Planer.ToList() != null)
            {
                return db.Planer.ToList();
            }
            else
            {
                return null;
            }
        }
    }
}