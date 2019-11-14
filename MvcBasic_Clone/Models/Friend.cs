using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{
    public class Friend
    {
        //public string ID { get; set; }
       
        public string FriendId { get; set; }
        public string Name { get; set; }
        public int Phone { get; set; }
        public string city { get; set; }
    }
}