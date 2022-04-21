using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using FoodTruckFinder.Data;
using System;
using System.Linq;
using System.Collections.Generic;

namespace FoodTruckFinder.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new FoodTruckContext(
                serviceProvider.GetRequiredService<DbContextOptions<FoodTruckContext>>()))
            {
                /*
                if (context.FoodTruck.Any())
                {
                    return;    
                }
                */

                #region snippet1
                context.FoodTruck.AddRange(
                    new FoodTruck
                    {
                        LocationId = 751253,
                        FacilityType = "Truck",
                        LocationDesc = "OLSOM ST: 14TH ST to 15TH ST (1800 - 1899)",
                        Address = "1800 FOLSOM ST",
                        Status = "REQUESTED",
                        FoodItems = new List<FoodItem>() { new FoodItem("Tacos"), new FoodItem("Burritos"), new FoodItem("Hot Dogs"), new FoodItem("Hamburgers")},
                        Location = new Location(37.7678524427181m, -122.416104892532m),

                    },
                

                    new FoodTruck
                    {
                        LocationId = 735318,
                        FacilityType = "Push Cart",
                        LocationDesc = "03RD ST: NEWCOMB AVE to OAKDALE AVE (4701 - 4799) -- EAST --",
                        Address = "5 THE EMBARCADERO",
                        Status = "REQUESTED",
                        FoodItems = new List<FoodItem>() { new FoodItem("Ice cream"), new FoodItem("Coffee")},
                        Location = new Location(37.7678524427181m, -122.416104892532m),
                    },

                    new FoodTruck
                    {
                        LocationId = 735319,
                        FacilityType = "Push Cart",
                        LocationDesc = "MARKET ST: DRUMM ST intersection",
                        Address = "4705 03RD ST",
                        Status = "EXPIRED",
                        FoodItems = new List<FoodItem>() { new FoodItem("Ice cream"), new FoodItem("Coffee") },
                        Location = new Location(37.7865580501799m, -122.40103337535m),
                    },

                    new FoodTruck
                    {
                        LocationId = 735320,
                        FacilityType = "Push Cart",
                        LocationDesc = "MARKET ST: DRUMM ST intersection",
                        Address = "4705 03RD ST",
                        Status = "EXPIRED",
                        FoodItems = new List<FoodItem>() { new FoodItem("Sandwich"), new FoodItem("Coffee") },
                        Location = new Location(37.7865580501799m, -122.40103337535m),
                    },
                    new FoodTruck
                    {
                        LocationId = 735321,
                        FacilityType = "Push Cart",
                        LocationDesc = "MARKET ST: DRUMM ST intersection",
                        Address = "4705 03RD ST",
                        Status = "EXPIRED",
                        FoodItems = new List<FoodItem>() { new FoodItem("Sandwich"), new FoodItem("Coffee") },
                        Location = new Location(37.7865580501799m, -122.40103337535m),
                    }

                );
                #endregion
                context.SaveChanges();
            }
        }


    }
}