using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }
        public ICollection<RestaurantReviews> Reviews { get; set; }
    }
}