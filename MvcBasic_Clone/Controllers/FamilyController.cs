using MvcBasic_Clone.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcBasic_Clone.Controllers
{
    public class FamilyController : Controller
    {
        // GET: Family
        private List<Family> CreateFamily() {
            return new List<Family>() {
               new  Family{ cardID="F127743233", Name="詹筱珮", age=65, city="台北", phone=0926776328  },
               new Family{ cardID="F127743944", Name="鄭銘福", age=70, city="高雄", phone=0955466576 },
               new Family{ cardID="F125546466", Name="鄭余玲", age=40, city="台中",phone=026778329 }

            };
        }
        public ActionResult Create(Family family) {
            var FamilyList = CreateFamily();
            FamilyList.Add(family);
            return View(family);

        }
        public ActionResult Index()
        {
            var FamilyList = CreateFamily();
            return View(FamilyList);
        }
    }
}