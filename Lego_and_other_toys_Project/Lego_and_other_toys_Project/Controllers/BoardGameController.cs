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
        public BoardGame SearchByAge(int age)
        {
            BoardGame set = context.BoardGames.FirstOrDefault(x => x.Age == age);
            if (age <= 0)
            {
                throw new ArgumentException("Invalid");
            }
            Console.WriteLine(set.Toy_name);
            Console.WriteLine(set.NoP);
            Console.WriteLine(set.Age);
            Console.WriteLine(set.Price);
            return set;
        }
        
        public BoardGame SearchByNoP(int noP)
        {
            BoardGame set = context.BoardGames.FirstOrDefault(x => x.NoP == noP);
            if (noP <= 0)
            {
                throw new ArgumentException("Invalid");
            }
            Console.WriteLine(set.Toy_name);
            Console.WriteLine(set.NoP);
            Console.WriteLine(set.Age);
            Console.WriteLine(set.Price);
            return set;
        }

    }
}
