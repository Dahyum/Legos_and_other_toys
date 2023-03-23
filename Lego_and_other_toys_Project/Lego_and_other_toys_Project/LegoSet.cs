using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.Collections.Specialized;

namespace Lego_and_other_toys_Project
{
    public class LegoSet : Toy
    {
        public LegoSet()
        {

        }

        public LegoSet(int set_id, string set_name, string series_name, bool in_stock, int age_group, int noB, decimal price, string rating, bool in_Production)
        {
            Set_id = set_id;
            Set_name = set_name;
            Series_name = series_name;
            In_stock = in_stock;
            Age_group = age_group;
            NoB = noB;
            Price = price;
            Rating = rating;
            In_Production = in_Production;
        }

        [Required]
        public int Set_id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Set_name { get; set; }

        [MaxLength(50)]
        [Required]
        public string Series_name { get; set; }

        [Required]
        public bool In_stock { get; set; }

        [Required]
        public int Age_group { get; set; }

        [Required]
        public int NoB { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        public string Rating { get; set; }

        [Required]
        public bool In_Production { get; set; }
    }
}
