using HarvirsBooks.DataAccess.Repository.IRepository;
using HarvirsBooks.Models;
/*using AspNetCore.Hosting;*/
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Domain.Uow;
using Microsoft.AspNetCore.Hosting;

namespace HarvirsBookStore.Areas.Admin.Controllers
{
    public class ProductController1 : Controller
    {
        [Area("Admin")]
        public class ProductController : Controller
        {
            private readonly IUnitOfWork unitOfWork;
            private readonly IUnitOfWork _unitofwork;
            private readonly IWebHostEnvironment _hostEnvironment;
           
            public ProductController(IUnitOfWork unitOfWork, IWebHostEnvironment hostEnvironment)
            {
                _unitofwork = unitOfWork;
                _hostEnvironment = hostEnvironment;

            }
            public IActionResult Index()
            {
                return View();
            }


       
        }
    }
}
