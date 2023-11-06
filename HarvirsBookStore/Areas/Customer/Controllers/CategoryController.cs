using HarvirsBooks.Models;
using Abp.Domain.Uow;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HarvirsBookStore.Areas.Customer.Controllers
{
    [Area("Admin")]
    public class CategoryController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;

        public CategoryController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult upsert(int? id) // action method for upsert
        {
            Category category = new Category(); // using Harvirsbooks.Models
            if(id == null)
            {
                // this is for create 
                return View(category);
            }
            // this is for edit
            category = _unitOfWork.Category.Get(id.GetValueOrDefault());
            if(category == null)
            {
                return NotFound();
            }
            return View();
        }

        private IActionResult View(Category category)
        {
            throw new NotImplementedException();
        }

        private IActionResult View()
        {
            throw new NotImplementedException();
        }

        // API calls here
        #region API CALLS
        [HttpGet]

        public IActionResult GetAll()
        {
            // return NotFound();
            var allObj = _unitOfWork.Category.GetAll();
            return Json(new { data = allObj });
        }

        private IActionResult Json(object p)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}
