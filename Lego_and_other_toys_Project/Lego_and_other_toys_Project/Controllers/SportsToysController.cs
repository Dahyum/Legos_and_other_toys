﻿using Lego_and_other_toys_Project.Data;
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
        public SportToy SearchByPrice(decimal price)
        {
            SportToy set = context.SportsToys.FirstOrDefault(x => x.Price == price);
            if (price <= 0)
            {
                throw new ArgumentException("Invalid");
            }
            return set;
            Console.WriteLine(set.ToyName);
            Console.WriteLine(set.Sport);
            Console.WriteLine(set.Price);
        }
        public SportToy SearchByName(string toyName)
        {
            SportToy set = context.SportsToys.FirstOrDefault(x => x.ToyName == toyName);
            if (toyName == null)
            {
                throw new ArgumentException("Invalid");
            }
            return set;
            Console.WriteLine(set.ToyName);
            Console.WriteLine(set.Sport);
            Console.WriteLine(set.Price);
        }
        public SportToy SearchBySport(string sport)
        {
            SportToy set = context.SportsToys.FirstOrDefault(x => x.ToyName == sport);
            if (sport == null)
            {
                throw new ArgumentException("Invalid");
            }
            return set;
            Console.WriteLine(set.ToyName);
            Console.WriteLine(set.Sport);
            Console.WriteLine(set.Price);
        }
    }
}
