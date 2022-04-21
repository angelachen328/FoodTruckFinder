using System.IO;
using CsvHelper;
using Microsoft.EntityFrameworkCore;
using FoodTruckFinder.Models;
using System;
using CsvHelper.Configuration;
using System.Globalization;

namespace FoodTruckFinder.Data
{
    public class FoodTruckContext : DbContext
    {
        public DbSet<FoodTruck> FoodTruck { get; set; }
        public FoodTruckContext(DbContextOptions<FoodTruckContext> options)
            : base(options)
        {
            //initialize_from_csv();
        }
        
        private void initialize_from_csv()
        {
            var config = new CsvConfiguration(CultureInfo.InvariantCulture)
            {
                HasHeaderRecord = false
            };

            using (var reader = new StreamReader(Environment.CurrentDirectory +@"\Data\Mobile_Food_Facility_Permit.csv"))
            using (var csv = new CsvReader(reader, config))
            {
                var records = csv.GetRecords<FoodTruck>();
                //TODO: parse csv and build an in-memory data of all the food trucks
               
            }
        }
    }
}