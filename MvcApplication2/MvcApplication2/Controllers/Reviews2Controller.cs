using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication2.Models;

namespace MvcApplication2.Controllers
{
    public class Reviews2Controller : Controller
    {
        //
        // GET: /Reviews2/

        public ActionResult Index()
        {
            //sentencia LINQ
            var model =
            from n in _reviews
            orderby n.Id
            select n;
            return View(model);
         
        }

        //
        // GET: /Reviews2/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Reviews2/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Reviews2/Create

        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Reviews2/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Reviews2/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Reviews2/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Reviews2/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        static List<HotelReviews> _reviews = new List<HotelReviews>
        {
            new HotelReviews{
                Id = 1,
                Nombre = "Sheraton",
                Ciudad = "Asuncion",
                Pais = "Paraguay",
                Rating = 10,
            },
              new HotelReviews{
                Id = 2,
                Nombre = "Hilton",
                Ciudad = "D.C.",
                Pais = "USA",
                Rating = 10,
            },
              new HotelReviews{
                Id = 3,
                Nombre = "The House",
                Ciudad = "Ghent",
                Pais = "Belgica",
                Rating = 10,
            },
        };
    }
}
