using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{

    public class Employees
    {
        [Display(Name="員工編號")]
        public int ID { get; set; }
        [Display(Name = "姓名")]
        public string Name { get; set; }
        [Display(Name = "電話")]
        public string Phone { get; set; }
        [Display(Name = "電子郵件")]
        public string email{ get; set;}
    }
}