using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lego_and_other_toys_Project
{
    public class BabyToy
    {
        public BabyToy()
        {

        }

        public BabyToy(int toy_id, string toy_name, int age, string size, decimal price)
        {
            Toy_id = toy_id;
            Toy_name = toy_name;
            Age = age;
            Size = size;
            Price = price;
        }

        [Required]
        public int Toy_id { get; set; }

        [Required]
        public string Toy_name { get; set; }

        [Required]
        public int Age { get; set; }

        [Required, MaxLength(50)]
        public string Size { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
