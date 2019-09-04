using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vega.Models;
using System.Data.Entity;

namespace Vega.Controllers
{
    public class RestaurantController : Controller
    {
        ApplicationDbContext _context;
        public RestaurantController()
        {
            _context = new ApplicationDbContext();
        }
        // GET: Resturant
        public ActionResult Index()
        {
            List<Restaurant> list = new List<Restaurant>();
            list = _context.Restaurants.ToList();
            return View(list);
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
            return RedirectToAction("index");

        }

        public ActionResult Edit(int id )
        {
            Restaurant restaurant = _context.Restaurants.Single(m => m.RestaurantId == id);
            return View(restaurant);
        }

        [HttpPost]
        public ActionResult Edit(Restaurant restaurant)
        {
            if(!ModelState.IsValid)
            {
                return RedirectToAction("Edit");
            }
            Restaurant resturantInDb = _context.Restaurants.Single(m => m.RestaurantId == restaurant.RestaurantId);
            resturantInDb.Name = restaurant.Name;
            resturantInDb.Description = restaurant.Description;
            resturantInDb.Status = restaurant.Status;
            resturantInDb.IsActive = restaurant.IsActive;
            resturantInDb.Area = restaurant.Area;
            restaurant.City = restaurant.City;
            restaurant.State = restaurant.State;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

     
        public ActionResult Delete(int id )
        {
            Restaurant restaurant = _context.Restaurants.Single(m => m.RestaurantId == id);
            _context.Restaurants.Remove(restaurant);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Details(int id)
        {
            Restaurant restaurant = _context.Restaurants.Single(m => m.RestaurantId == id);
            return View(restaurant);
        }

    }
}