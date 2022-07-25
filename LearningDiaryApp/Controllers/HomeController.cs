using LearningDiaryApp.Data;
using LearningDiaryApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LearningDiaryApp.Controllers
{
    public class HomeController : Controller
    {
     
        private readonly ILogger<HomeController> _logger;

        private readonly LearningDiaryAppContext _context;


        public HomeController(ILogger<HomeController> logger, LearningDiaryAppContext context)
        {
            _context = context;
            _logger = logger;
        }


     

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public IActionResult Privacy()
        {
            return View();
        }

        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var topic = await _context.Topic
                .FirstOrDefaultAsync(m => m.Id == id);
            if (topic == null)
            {
                return NotFound();
            }

            return View(topic);
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Topic.ToListAsync());
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
