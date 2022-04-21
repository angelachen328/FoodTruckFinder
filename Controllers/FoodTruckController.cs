using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FoodTruckFinder.Data;
using FoodTruckFinder.Models;

namespace FoodTruckFinder.Controllers
{
    public class FoodTruckController : Controller
    {
        private readonly FoodTruckContext _context;

        public FoodTruckController(FoodTruckContext context)
        {
            _context = context;
        }

        // GET: all food trucks
        public async Task<IActionResult> Index()
        {
            return View(await _context.FoodTruck.ToListAsync());
        }
    }
}
