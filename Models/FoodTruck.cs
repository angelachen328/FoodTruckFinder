using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FoodTruckFinder.Models
{
    public class FoodTruck
    {
        public FoodTruck()
        {

        }
        public FoodTruck(long id, string desc)        {
            LocationId = 1;
            LocationDesc = desc;
        }
        public FoodTruck(long LocationId, string facilityType, string locationDesc, string address, string status, List<FoodItem> items, Location loc)
        {
            this.LocationId = LocationId;
            this.FacilityType = facilityType;
            this.LocationDesc = locationDesc;
            this.Address = address;
            this.Status = status;
            this.FoodItems = items;
            this.Location = loc;
        }
                      
        [Key]
        public long LocationId { get; set; }

        public string LocationDesc { get; set; }
        public string FacilityType { get; set; }
        public string Address { get; set; }

        public string Status { get; set; }

        public List<FoodItem> FoodItems { get; set; }
        public Location Location {get;set;}
    }
}