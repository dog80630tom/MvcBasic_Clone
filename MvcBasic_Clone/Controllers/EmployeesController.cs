using MvcBasic_Clone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class EmployeesController : Controller
    {
        private FriendContext db = new FriendContext();
        public ActionResult EmployeeList() {
            List<Employees> employees = new List<Employees>() {
                new Employees{ ID=1, Name="David", Phone="123456789", email="change@gamil.com" },
                new Employees{ ID=2, Name="Jack", Phone="123456789", email="Tom@gamil.com" },
                new Employees{ ID=3, Name="Tony",Phone="0955466576", email="Jack@gmail.com" }
            };
            return View(employees);
        }
        // GET: Employees
        public ActionResult Index()
        {

            return View(db.Employees.ToList());
        }
    }
}