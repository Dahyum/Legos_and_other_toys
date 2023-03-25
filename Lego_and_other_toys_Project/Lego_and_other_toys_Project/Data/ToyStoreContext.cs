using Lego_and_other_toys_Project.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lego_and_other_toys_Project.Data
{
    public class ToyStoreContext : DbContext
    {
        public ToyStoreContext()
        {

        }

        public ToyStoreContext(DbContextOptions options) : base(options)
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
            modelbuilder.Entity<LegoSet>().Property( x=>x.Set_id).ValueGeneratedOnAdd();
            modelbuilder.Entity<BabyToy>().Property( x=>x.Toy_id).ValueGeneratedOnAdd();
            modelbuilder.Entity<SportToy>().Property( x=>x.Toy_id).ValueGeneratedOnAdd();
            modelbuilder.Entity<BoardGame>().Property( x=>x.Toy_id).ValueGeneratedOnAdd();

            

            base.OnModelCreating(modelbuilder);
        }

    }
}
