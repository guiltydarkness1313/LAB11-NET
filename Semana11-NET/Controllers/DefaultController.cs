using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;

namespace Semana11_NET.Controllers
{
    public class DefaultController : Controller
    {
        private DBConnection db = new DBConnection();
        // GET: Default
        public ActionResult Index()
        {
            List<Customer> customers = db.getCustomers();
            return View(customers);
        }

        public ActionResult Employees()
        {
            List<Employee> employees = db.GetEmployees();
            return View(employees);
        }
    }
}