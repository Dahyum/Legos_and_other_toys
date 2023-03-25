using Lego_and_other_toys_Project.Data;
using Lego_and_other_toys_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lego_and_other_toys_Project.Controllers
{
    public class BoardGameController
    {
        private ToyStoreContext context;
        public BoardGameController()
        {
            context = new ToyStoreContext();
        }
        public BoardGame SearchByName(string name)
        {
            BoardGame set = context.BoardGames.FirstOrDefault(x => x.Toy_name == name);
            if (name == null)
            {
                throw new ArgumentException("Invalid");
            }
            return set;
            Console.WriteLine(set.Toy_name);
            Console.WriteLine(set.NoP);
            Console.WriteLine(set.Age);
            Console.WriteLine(set.Price);
        }
        public BoardGame SearchByPrice(decimal price)
        {
            BoardGame set = context.BoardGames.FirstOrDefault(x => x.Price == price);
            if (price <= 0)
            {
                throw new ArgumentException("Invalid");
            }
            return set;
            Console.WriteLine(set.Toy_name);
            Console.WriteLine(set.NoP);
            Console.WriteLine(set.Age);
            Console.WriteLine(set.Price);
        }
        public BoardGame NoP(int noP)
        {
            BoardGame set = context.BoardGames.FirstOrDefault(x => x.NoP == noP);
            if (noP <= 0)
            {
                throw new ArgumentException("Invalid");
            }
            return set;
            Console.WriteLine(set.Toy_name);
            Console.WriteLine(set.NoP);
            Console.WriteLine(set.Age);
            Console.WriteLine(set.Price);
        }

    }
}
