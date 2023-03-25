using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lego_and_other_toys_Project
{
    public class SportToy : Toy
    {
        public SportToy()
        {
                
        }

        public SportToy(int toy_id, string toyName, string sport, decimal price)
        {
            Toy_id = toy_id;
            ToyName = toyName;
            Sport = sport;
            Price = price;
        }
        [Key]
        [Required]
        public int Toy_id { get; set; }

        [Required]
        [MaxLength(50)]
        public string ToyName { get; set; }

        [Required]
        [MaxLength(50)]
        public string Sport { get; set; }

        [Required, MaxLength(50)]
        public decimal Price { get; set; }

    }
}
