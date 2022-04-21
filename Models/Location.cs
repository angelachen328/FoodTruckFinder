using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FoodTruckFinder.Models
{
    public class Location
    {
        [Key]
        public decimal Longtitude { get; private set; }
        public decimal Latitude { get; private set; }
        public Location(decimal latitude, decimal longtitude)
        {
            this.Latitude = latitude;
            this.Longtitude = longtitude;
        }
    }
}
