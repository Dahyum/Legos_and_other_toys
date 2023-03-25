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
                Console.WriteLine(item.Toy_name);
                Console.WriteLine(item.Size);
                Console.WriteLine(item.Age);
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
                Console.WriteLine(item.Toy_name);
                Console.WriteLine(item.Size);
                Console.WriteLine(item.Age);
            }
        }
    }
}
