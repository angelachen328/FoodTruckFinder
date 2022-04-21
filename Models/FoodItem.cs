using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodTruckFinder.Models
{
    public class FoodItem
    {
        [Key]
        public string Name { get; private set;}
        public FoodItem(string name)
        {
            Name = name;
        }
    }
}
