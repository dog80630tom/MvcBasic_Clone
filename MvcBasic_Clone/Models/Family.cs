using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{
    public class Family
    {

        public int Id { get; set; }
        [Display(Name = "身分證字號")]
        public string cardID { get; set; }
        [Display(Name = "家人姓名")]
        public string Name { get; set; }
        [Display(Name = "家人電話")]
        public int phone { get; set; }
        [Display(Name = "家人年紀")]
        public int age { get; set; }
        [Display(Name = "家人居住城市")]
        public string city { get; set; }
       
    }
}