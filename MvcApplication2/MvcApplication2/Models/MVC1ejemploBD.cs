using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class MVC1ejemploBD : DbContext
    {
        public MVC1ejemploBD()
            : base("name=CONN")
        {
        }

        public DbSet<Restaurant> Restaurant { get; set; }

        public DbSet<RestaurantReviews> Reviews { get; set; }

    }
}