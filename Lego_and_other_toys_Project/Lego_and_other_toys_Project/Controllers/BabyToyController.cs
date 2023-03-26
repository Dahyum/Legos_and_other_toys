using Lego_and_other_toys_Project.Data;
using Lego_and_other_toys_Project.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lego_and_other_toys_Project.Controllers
{
    public class BabyToyController
    {
        private ToyStoreContext context;
        public BabyToyController()
        {
            context = new ToyStoreContext();
        }

        public void SearchBysize(string size)
        {
            List<BabyToy> babytoy = context.BabyToys.Where(x => x.Size == size).ToList();
            if (size == null)
            {
                throw new ArgumentException("Invalid");
            }
            foreach (var item in babytoy)
            {
                Console.WriteLine($"Name: {item.Toy_name}");
                Console.WriteLine($"Size {item.Size}");
                Console.WriteLine($"Age: {item.Age}\n-------------------------");
            }
        }

        public void SearchByAge(int age)
        {
            List<BabyToy> babytoy = context.BabyToys.Where(x => x.Age >= age).ToList();
            if (age <= 0)
            {
                throw new ArgumentException("Invalid");
            }
            foreach (var item in babytoy)
            {
                Console.WriteLine($"Name: {item.Toy_name}");
                Console.WriteLine($"Size {item.Size}");
                Console.WriteLine($"Age: {item.Age}\n-------------------------");
            }
        }

        public void AddBabyToy(BabyToy babytoy)
        {
            context.Add(babytoy);
            context.SaveChanges();
        }

        public BabyToy GetBabyToyByName(string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Name cannot be empty!");
            }

            BabyToy babytoy = context.BabyToys.FirstOrDefault(x => x.Toy_name == name);
            if (babytoy == null)
            {
                throw new ArgumentException("No toy found with this name!");
            }
            return babytoy;
        }

        public void DeleteBabyToyByName(string name)
        {
            BabyToy babytoytodelete = GetBabyToyByName(name);
            context.Remove(babytoytodelete);
            context.SaveChanges();
        }

        public void EditBabyToy(BabyToy babyToy, string newname, int newage, string newsize, decimal newprice)
        {
            babyToy.Toy_name = newname;
            babyToy.Age = newage;
            babyToy.Size = newsize;
            babyToy.Price = newprice;
            context.Update(babyToy);
            context.SaveChanges();
        }
    }
}
