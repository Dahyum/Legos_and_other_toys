using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lego_and_other_toys_Project
{
    public class ToyStore : DbContext
    {
        public ToyStore()
        {

        }

        public ToyStore(DbContextOptions options) : base(options)
        {

        }

        public virtual DbSet<LegoSet> LEGOSets { get; set; }

        public virtual DbSet<SportToy> SportsToys { get; set; }

        public virtual DbSet<BoardGame> BoardGames { get; set; } 

        public virtual DbSet<BabyToy> BabyToys { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder dbContextOptionsBuilder)
        {
            dbContextOptionsBuilder.UseSqlServer(Config.connectionString);
            
            base.OnConfiguring(dbContextOptionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {
            base.OnModelCreating(modelbuilder);
        }

    }
}
