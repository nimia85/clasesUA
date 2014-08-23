using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcApplication2.Models
{
    public class HotelReviews
    {

        public int Id { get; set; }

        public string Nombre { get; set; }

        public string Ciudad { get; set; }

        public string Pais { get; set; }

        public int Rating { get; set; }
    }
}