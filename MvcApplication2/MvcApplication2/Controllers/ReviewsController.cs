//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Web;
//using System.Web.Mvc;
//using MvcApplication2.Models;

//namespace MvcApplication2.Controllers
//{
//    public class ReviewsController : Controller
//    {
//        //
//        // GET: /Reviews/

//        public ActionResult Index()
//        {
//            //sentencia LINQ
//            var model = 
//            from r in _reviews
//            orderby r.Pais
//            select r;
//            return View(model);
//        }

//        //
//        // GET: /Reviews/Details/5

//        public ActionResult Details(int id)
//        {
//            return View();
//        }

//        //
//        // GET: /Reviews/Create

//        public ActionResult Create()
//        {
//            return View();
//        }

//        //
//        // POST: /Reviews/Create

//        [HttpPost]
//        public ActionResult Create(FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add insert logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        //
//        // GET: /Reviews/Edit/5

//        public ActionResult Edit(int id)
//        {
//            return View();
//        }

//        //
//        // POST: /Reviews/Edit/5

//        [HttpPost]
//        public ActionResult Edit(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add update logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        //
//        // GET: /Reviews/Delete/5

//        public ActionResult Delete(int id)
//        {
//            return View();
//        }

//        //
//        // POST: /Reviews/Delete/5

//        [HttpPost]
//        public ActionResult Delete(int id, FormCollection collection)
//        {
//            try
//            {
//                // TODO: Add delete logic here

//                return RedirectToAction("Index");
//            }
//            catch
//            {
//                return View();
//            }
//        }

//        static List<RestaurantReviews> _reviews = new List<RestaurantReviews>
//        {
//            new RestaurantReviews{
//                Id = 1,
//                Nombre = "El bolsi",
//                Ciudad = "Asuncion",
//                Pais = "Paraguay",
//                Rating = 10,
//            },
//              new RestaurantReviews{
//                Id = 2,
//                Nombre = "Marrakensh",
//                Ciudad = "D.C.",
//                Pais = "USA",
//                Rating = 10,
//            },
//              new RestaurantReviews{
//                Id = 3,
//                Nombre = "The House of Helliot",
//                Ciudad = "Ghent",
//                Pais = "Belgica",
//                Rating = 10,
//            },
//        };
//    }
//}
