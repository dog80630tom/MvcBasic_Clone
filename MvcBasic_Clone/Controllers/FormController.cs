using MvcBasic_Clone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class FormController : Controller
    {
        private CardDBContext cardDB = new CardDBContext();
        // GET: Form
        public ActionResult UserInfo(Info info) {
            var id = info.Id;
            if (id == null)
            {
                return new 
            }
            cardDB.Infos.Add();
            return View();
        }
        public ActionResult Index()
        {
            return View();
        }
    }
}