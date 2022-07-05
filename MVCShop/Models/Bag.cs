using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCShop.Models
{
    public class Bag
    {
        [Required(ErrorMessage = "Please enter bag name!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please enter bag image URL!")]
        public string ImgUrl { get; set; }

        [Required(ErrorMessage = "Please enter bag price!")]
        public string Price { get; set; }

        [Required(ErrorMessage = "Please enter bag exprot country!")]
        public string Export { get; set; }

        public string Discription { get; set; }
    }
}
