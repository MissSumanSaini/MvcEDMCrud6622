using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcEDMCrud6622.Controllers;

namespace MvcEDMCrud6622.Controllers
{
    public class EmpController : Controller
    {

        //  DatabaseContext _db = new DatabaseContext();

        MvcEntityDmCrud6622Entities _db = new MvcEntityDmCrud6622Entities();

        // GET: Employee
        [HttpGet]
        public ActionResult AddEmployee()
        {
           return View();
        }

        [HttpPost]
        public ActionResult AddEmployee(tblEmployee _emp)
        {
            _db.tblEmployees.Add(_emp);
            _db.SaveChanges();
            
            return View();
        }

       
    }
}