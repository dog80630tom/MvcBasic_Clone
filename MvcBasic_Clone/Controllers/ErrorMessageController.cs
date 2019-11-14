using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class ErrorMessageController : Controller
    {
        // GET: ErrorMessage
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ErrorView() {
            if (!TempData.ContainsKey("ErrorMessage"))
            {
                return new EmptyResult();
            }
            TempData.Keep();
            return View();
        }
    }
}