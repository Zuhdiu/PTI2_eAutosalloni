using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PTI2_eAutosalloni.Areas.Admin.Controllers
{
    public class AdminHomeController : Controller
    {
        [Area("Admin")]
       // [Authorize(Roles = "Admin")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
