using Entities;
using Logic;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class CategoryController : Controller
    {
        CategoryLogic logic = new CategoryLogic();
        // GET: Customer
        public ActionResult Index()
        {

            List<Entities.Categories> categories = logic.GetAll();
            List<CategoryView> categoryView = categories.Select(s => new CategoryView
            {
                Id = s.CategoryID,
                Description = s.Description,
            }).ToList();
            return View(categoryView);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(CategoryView categoryView)
        {
            try
            {
                var categoryEntity = new Categories
                {
                    Description = categoryView.Description
                };
                logic.Add(categoryEntity);
                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(int id)
        {
            logic.Delete(id);
            return RedirectToAction("Index");
        }
    }
}