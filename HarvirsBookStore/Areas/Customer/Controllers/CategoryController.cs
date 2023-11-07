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
            Category category = new(); // using Harvirsbooks.Models
            if(id == null)
            {
                // this is for create 
                return View(category);
            }
            // use HTTP POST to define the post-action method
            [HttpPost]
            [ValidateAntiForgeryToken]
            public IActionResult Upsert(Category category);
            {
                if(ModelState.IsValid)
                {
                    if(category.Id == 0)
                    {
                        _unitOfWork.Category.Add(category);
                    
                    }
                    
                    else
                    {
                        _unitOfWork.Category.Update(category);
                    }
                    _unitOfWork.SaveChanges
                        return RedirectToAction(nameof(Index));  // to see all 
                }

            }
           
            return View(category);
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
            var allObj = _unitOfWork. Category.GetAll();
            return Json(new { data = allObj });
        }
        [HttpDelete]
        private IActionResult Delete(int id)
        {
            var objFromDb = _unitOfWork.Category.Get(id);
            if (objFromDb == null)
            {
                return json(new { success = false, message = "Delete Successfull" });
        }
            #endregion

    

        }
}
