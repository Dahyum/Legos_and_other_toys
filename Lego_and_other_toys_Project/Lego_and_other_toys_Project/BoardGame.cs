using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lego_and_other_toys_Project
{
    public class BoardGame
    {
        public BoardGame()
        {

        }

        public BoardGame(int toy_id, string toy_name, int noP, int age, decimal price)
        {
            Toy_id = toy_id;
            Toy_name = toy_name;
            NoP = noP;
            Age = age;
            Price = price;
        }

        [Required]
        public int Toy_id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Toy_name { get; set; }

        [Required]
        public int NoP { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public decimal Price { get; set; }
    }
}
