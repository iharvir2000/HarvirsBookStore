using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarvirsBookStore.Areas.Admin.Controllers
{
    public class ProductController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
