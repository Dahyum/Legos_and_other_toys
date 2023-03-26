using Lego_and_other_toys_Project.Data;
using Lego_and_other_toys_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lego_and_other_toys_Project.Controllers
{
    public class LegoController
    {
        private ToyStoreContext context;
        public LegoController()
        {
            context = new ToyStoreContext();
        }

        public void SearchByName(string name)
        {
            List<LegoSet> sets = context.LEGOSets.Where(x => x.Set_name == name).ToList();
            if (name == null)
            {
                throw new ArgumentException("Invalid");
            }
            foreach (var item in sets)
            {
                Console.WriteLine($"Name of Set: {item.Set_name}");
                Console.WriteLine($"Name of Series: {item.Series_name}");
                Console.WriteLine($"Age group: {item.Age_group}");
                Console.WriteLine($"Number of Bricks: {item.NoB}");
                Console.WriteLine($"Price: {item.Price}");
                Console.WriteLine($"Rating: {item.Rating}");
                Console.WriteLine($"In Stock?: {item.In_stock}");
                Console.WriteLine($"In Production?: {item.In_Production}\n-------------------------");
            }
        }

        public void SearchByPrice(decimal price)
        {
            List<LegoSet> sets = context.LEGOSets.Where(x => x.Price <= price).ToList();
            if (price <= 0)
            {
                throw new ArgumentException("Invalid");
            }
            foreach (var item in sets)
            {
                Console.WriteLine($"Name of Set: {item.Set_name}");
                Console.WriteLine($"Name of Series: {item.Series_name}");
                Console.WriteLine($"Age group: {item.Age_group}");
                Console.WriteLine($"Number of Bricks: {item.NoB}");
                Console.WriteLine($"Price: {item.Price}");
                Console.WriteLine($"Rating: {item.Rating}");
                Console.WriteLine($"In Stock?: {item.In_stock}");
                Console.WriteLine($"In Production?: {item.In_Production}\n-------------------------");
            }
        }

        public void SearchByRating(string rating)
        {
            List<LegoSet> sets = context.LEGOSets.Where(x => x.Rating == rating).ToList();
            if (rating == null)
            {
                throw new ArgumentException("Invalid");
            }
            foreach (var item in sets)
            {
                Console.WriteLine($"Name of Set: {item.Set_name}");
                Console.WriteLine($"Name of Series: {item.Series_name}");
                Console.WriteLine($"Age group: {item.Age_group}");
                Console.WriteLine($"Number of Bricks: {item.NoB}");
                Console.WriteLine($"Price: {item.Price}");
                Console.WriteLine($"Rating: {item.Rating}");
                Console.WriteLine($"In Stock?: {item.In_stock}");
                Console.WriteLine($"In Production?: {item.In_Production}\n-------------------------");
            }
        }
        public void AddLegoSet(LegoSet legoSet)
        {
            context.Add(legoSet);
            context.SaveChanges();
        }

        public LegoSet GetLegoSetByName(string Legoname)
        {
            if (string.IsNullOrEmpty(Legoname))
            {
                throw new ArgumentException("Name cannot be empty!");
            }

            LegoSet legoSet = context.LEGOSets.FirstOrDefault(x => x.Set_name == Legoname);
            if (legoSet == null)
            {
                throw new ArgumentException("No toy found with this name!");
            }
            return legoSet;
        }

        public void DeleteLegoSetByName(string name)
        {
            LegoSet legosetdelete = GetLegoSetByName(name);
            context.Remove(legosetdelete);
            context.SaveChanges();
        }
        public void EditLegoSet(LegoSet legoSet, string newname, string sName, bool updateStock, int updateAge, int NewNoB, decimal newPrice, string newRating, bool updateProduction)
        {
            legoSet.Set_name = newname;
            legoSet.Series_name = sName;
            legoSet.In_stock = updateStock;
            legoSet.Age_group = updateAge;
            legoSet.NoB = NewNoB;
            legoSet.Price = newPrice;
            legoSet.Rating = newRating;
            legoSet.In_Production = updateProduction;
            context.Update(legoSet);
            context.SaveChanges();
        }       
    }
}
