using Beryllium.DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Beryllium.Areas.BerylliumAdminPanel.Controllers
{
    [Area("BerylliumAdminPanel")]

    public class DashboardController : Controller
    {
   
        public IActionResult Index()
        {
            return View();
        }
      
    }
}
