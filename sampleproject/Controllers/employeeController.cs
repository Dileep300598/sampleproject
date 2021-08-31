using sampleproject.Models;
using sampleproject.service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace sampleproject.Controllers
{
    public class employeeController : Controller
    {
        private employeeservices _empservices;



        public ActionResult list()
        {
            _empservices = new employeeservices();
            var model = _empservices.GetEmpList();
            return View(model);
        }


        public ActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddEmployee(employeemodel model)
        {
            _empservices = new employeeservices();
            _empservices.insertemployee(model);

            return RedirectToAction("list");

        }


        public ActionResult editemployee(int id)
        {
            _empservices = new employeeservices();

            var model = _empservices.geteditbyid(id);
            return View();
        }
        [HttpPost]
        public ActionResult EditEmployee(employeemodel model) 
        {
            _empservices = new employeeservices();
            _empservices.UpdateEmp(model);

            return RedirectToAction("list");

        
        
        }
        public ActionResult deleteemployee(int id)
        {
            _empservices = new employeeservices();
            _empservices.DeleteEmp(id);
            return RedirectToAction("list");
        }

    }
}