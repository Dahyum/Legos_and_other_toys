using System;
using Lego_and_other_toys_Project.Data;
using Lego_and_other_toys_Project.Data.Models;


namespace Lego_and_other_toys_Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //lmfao praim neshto

            using (var db = new ToyStoreContext())
            {
                db.BabyToys.Add(new BabyToy { Toy_name = "Mickey-Mouse Plushie" });
                db.SaveChanges();
                foreach (var babytoy in db.BabyToys)
                {
                    Console.WriteLine(babytoy.Toy_name);
                }
            }
            Console.ReadKey();






            Console.WriteLine("            WELCOME THE THE TOY STORE!    \n ======================================================= \n " +
                "What would you like to do? \n 1. Look for LEGO toys? \n 2. Look for other toys?");




        }
    }
}
