using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class PassDataController : Controller
    {
        // GET: PassData
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult PetData() {
            ViewData["ShopName"] = "汪星人寵物店";
            ViewBag.Adress = "新北市淡水區";
            List<string> pet = new List<string>();
            pet.Add("狗");
            pet.Add("貓");
            pet.Add("雞");
            pet.Add("寵物豬");
            ViewData.Model = pet;
            return View();
        }
        public ActionResult PassViewBag()
        {
            ViewBag.Name = "Tom";
            ViewBag.name = "Jack";
            ViewBag.Height = 165;
            ViewBag.weight = 50;
            ViewBag.married = false;

            return View();
        }

        public ActionResult PassViewData()
        {
            ViewData["Name"] = "Tom";
            ViewData["Age"] = 24;
            ViewData["single"] = true;
            return View();

        }
        public ActionResult PassTempData() {
            TempData["ErrorMessage"] = "錯誤:請趕快關掉頁面";
            TempData["UserName"] = "Jack";
            TempData["Time"] = DateTime.Now.ToLongTimeString();

            return RedirectToAction("ErrorView","ErrorMessage");
        }
    }
}