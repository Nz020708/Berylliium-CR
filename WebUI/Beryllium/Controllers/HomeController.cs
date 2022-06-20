using Beryllium.DAL;
using Beryllium.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _db { get; }
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            HomeVM home = new HomeVM
            {
                Places = _db.Places.Where(p => !p.isDeleted).ToList()
            };

            return View(home);
        }
    }
}
