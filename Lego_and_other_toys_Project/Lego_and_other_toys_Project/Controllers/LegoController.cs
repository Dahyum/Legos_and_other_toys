using Lego_and_other_toys_Project.Data;
using Lego_and_other_toys_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lego_and_other_toys_Project.Controllers
{
    internal class LegoController
    {
        private ToyStoreContext context;
        public LegoController()
        {
            context = new ToyStoreContext();
        }

        public LegoSet SearchByName(string name)
        {
            LegoSet set = context.LEGOSets.FirstOrDefault(x=>x.Set_name == name);
            if (name == null)
            {
                throw new ArgumentException("Invalid");
            }
            return set;
            Console.WriteLine(set.Set_name);
            Console.WriteLine(set.Series_name);
            Console.WriteLine(set.Age_group);
            Console.WriteLine(set.NoB);
            Console.WriteLine(set.Price);
            Console.WriteLine(set.Rating);
            Console.WriteLine(set.In_stock);
            Console.WriteLine(set.In_Production);

        }

        public LegoSet SearchByPrice(decimal price)
        {
            LegoSet set = context.LEGOSets.FirstOrDefault(x => x.Price == price);
            if (price <= 0)
            {
                throw new ArgumentException("Invalid");
            }
            return set;
            Console.WriteLine(set.Set_name);
            Console.WriteLine(set.Series_name);
            Console.WriteLine(set.Age_group);
            Console.WriteLine(set.NoB);
            Console.WriteLine(set.Price);
            Console.WriteLine(set.Rating);
            Console.WriteLine(set.In_stock);
            Console.WriteLine(set.In_Production);

        }

        public LegoSet SearchByRating(string rating)
        {
            LegoSet set = context.LEGOSets.FirstOrDefault(x => x.Rating == rating);
            if (rating == null)
            {
                throw new ArgumentException("Invalid");
            }
            return set;
            Console.WriteLine(set.Set_name);
            Console.WriteLine(set.Series_name);
            Console.WriteLine(set.Age_group);
            Console.WriteLine(set.NoB);
            Console.WriteLine(set.Price);
            Console.WriteLine(set.Rating);
            Console.WriteLine(set.In_stock);
            Console.WriteLine(set.In_Production);

        }
    }
}
