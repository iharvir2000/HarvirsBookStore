using HarvirsBooks.DataAccess.Repository.IRepository;
using Abp.Domain.Uow;
using HarvirsBooks.Models;
using HarvirsBookStore.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using IUnitOfWork = HarvirsBooks.DataAccess.Repository.IRepository.IUnitOfWork;

namespace HarvirsBookStore.Area.Customer.Controllers
{
    [Area("Customer")]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUnitOfWork _unifOfWork;

        public HomeController(ILogger<HomeController> logger, IUnitOfWork unifOfWork)
        {
            _logger = logger;
            _unifOfWork = unifOfWork;
        }

        public IActionResult Index()
        {
            IEnumerable<Product> productList = _unifOfWork.Product.GetAll(includeProperties: "Category,CoverType");
            return View(productList);
        }

        public IActionResult Privacy()
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