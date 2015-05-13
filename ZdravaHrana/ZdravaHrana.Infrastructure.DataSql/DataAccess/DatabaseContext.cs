using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZdravaHrana.Domain.Entities;
using ZdravaHrana.Domain.Entities.Interfaces;

namespace ZdravaHrana.Infrastructure.DataSql.DataAccess
{
   public class DatabaseContext : DbContext
    {
        public DbSet<Recipe> Recipe { get; set; }
        public DbSet<Food> Food { get; set; }
        public DbSet<Ingredients> Ingredients { get; set; }
        public DbSet<Planer> Planer { get; set; }
        public DbSet<PlanerRecipe> PlanerRecipe { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        }
    }

