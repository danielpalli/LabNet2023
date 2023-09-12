﻿using Entities;
using Logic;
using MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class CustomerController : Controller
    {
        CustomersLogic logic = new CustomersLogic();
        // GET: Customer
        public ActionResult Index()
        {

            List<Entities.Customers> customers = logic.GetAll();
            List<CustomerView> customerView = customers.Select(s => new CustomerView
            {
                Id = s.CustomerID,
                ContactName = s.ContactName,
            }).ToList();
            return View(customerView);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(CustomerView customerView)
        {
            try
            {
                var customerEntity = new Customers
                {
                    ContactName = customerView.ContactName
                };
                logic.Add(customerEntity);
                return RedirectToAction("Index");
            } 
            catch (Exception ex)
            { 
                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(string id)
        {
            logic.Delete(id);
            return RedirectToAction("Index");
        }
    }
}