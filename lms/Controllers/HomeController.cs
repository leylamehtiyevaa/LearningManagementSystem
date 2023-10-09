﻿using System.Diagnostics;
using lms.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace lms.Controllers
{

    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly LmsDBContext _dbContext;
        public HomeController(ILogger<HomeController> logger, LmsDBContext lmsDBContext)
        {
            _logger = logger;
            _dbContext = lmsDBContext;
        }

        public IActionResult Index()
        {
            var viewModel = new HomeViewModel
            {
                Categories = _dbContext.Category.ToList(),
            };

            return View(viewModel);
        }

        public async Task<IActionResult> CourseList()
        {
            var lmsDBContext = _dbContext.Course.Include(c => c.Category);
            return View(await lmsDBContext.ToListAsync());
        }

        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult Staff()
        {
            return View();
        }
        public IActionResult News()
        {
            return View();
        }
        public IActionResult Gallery()
        {
            return View();
        }



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}