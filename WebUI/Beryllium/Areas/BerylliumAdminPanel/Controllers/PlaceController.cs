using Beryllium.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Areas.BerylliumAdminPanel.Controllers
{
    [Area("BerylliumAdminPanel")]

    public class PlaceController : Controller
    {
        private AppDbContext _db { get; }
        public PlaceController(AppDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            return View(_db.Places.Where(p => !p.isDeleted).ToList());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(string Name)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            return Json(Name);
        }
    }
}
