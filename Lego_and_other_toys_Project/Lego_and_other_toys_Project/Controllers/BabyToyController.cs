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

        public BabyToy SearchBysize(string size)
        {
            BabyToy babytoy = context.BabyToys.FirstOrDefault(x => x.Size == size);
            if (size == null)
            {
                throw new ArgumentException("Invalid");
            }
            Console.WriteLine(babytoy.Toy_name);
            Console.WriteLine(babytoy.Size);
            Console.WriteLine(babytoy.Age);
            return babytoy;
        }

        public BabyToy SearchByAge(int age)
        {
            BabyToy babytoy = context.BabyToys.FirstOrDefault(x => x.Age == age);
            if (age <= 0)
            {
                throw new ArgumentException("Invalid");
            }
            Console.WriteLine(babytoy.Toy_name);
            Console.WriteLine(babytoy.Size);
            Console.WriteLine(babytoy.Age);
            return babytoy;
        }
    }
}
