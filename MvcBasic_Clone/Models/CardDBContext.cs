using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcBasic_Clone.Models
{
    public class CardDBContext : DbContext
    {
        public CardDBContext() : base("name=CarDBContext")
        {
        }
        public DbSet<Info> Infos { get; set; }
    }
}