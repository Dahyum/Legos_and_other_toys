using Lego_and_other_toys_Project.Data;
using Lego_and_other_toys_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lego_and_other_toys_Project.Controllers
{
    public class SportsToysController
    {
        private ToyStoreContext context;
        public SportsToysController()
        {
            context = new ToyStoreContext();
        }
        public void SearchByPrice(decimal price)
        {
            List<SportToy> sets = context.SportsToys.Where(x => x.Price <= price).ToList();
            if (price <= 0)
            {
                throw new ArgumentException("Invalid");
            }
            foreach (var item in sets)
            {
                Console.WriteLine($"Name: {item.ToyName}");
                Console.WriteLine($"Sport: {item.Sport}");
                Console.WriteLine($"Price: {item.Price}\\n-------------------------");
            }
        }
        
        public void SearchBySport(string sport)
        {
            List<SportToy> sets = context.SportsToys.Where(x => x.Sport == sport).ToList();
            if (sport == null)
            {
                throw new ArgumentException("Invalid");
            }
            foreach (var item in sets)
            {
                Console.WriteLine($"Name: {item.ToyName}");
                Console.WriteLine($"Sport: {item.Sport}");
                Console.WriteLine($"Price: {item.Price}\\n-------------------------");
            }
        }
    }
}
