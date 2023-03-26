using Lego_and_other_toys_Project.Data;
using Lego_and_other_toys_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        public void AddSportToy(SportToy sporttoy)
        {
            context.Add(sporttoy);
            context.SaveChanges();
        }

        public SportToy GetSportToyByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be empty!");
            }
            
            SportToy sporttoy =  context.SportsToys.FirstOrDefault(x=>x.ToyName == name);
            if (sporttoy==null)
            {
                throw new ArgumentException("No toy found with this name!");
            }
            return sporttoy;
        }

        public void DeleteSportToyByName(string name)
        {
            SportToy sporttoytodelete = GetSportToyByName(name);
            context.Remove(sporttoytodelete);
            context.SaveChanges();

        }
        public void EditSportToy(SportToy sportToy, string newname, string sport, decimal newprice)
        {
            sportToy.ToyName = newname;
            sportToy.Sport = sport;
            sportToy.Price = newprice;
            context.Update(sportToy);
            context.SaveChanges();
        }
        public List<SportToy> GetAllSportToys()
        {
            using (context = new ToyStoreContext())
            {
                return context.SportsToys.ToList();
            }
        }
    }
}
