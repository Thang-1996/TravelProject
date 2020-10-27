using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelAssigments.Models;

namespace TravelAssigments.Controllers
{
    public class LocationController : Controller
    {
        ServicesClient servicesClient = new ServicesClient();
        // GET: Location
        public ActionResult Index()
        {
            ViewBag.listLocation = servicesClient.getAllLocations();
            return View();
        }

        // GET: Location/Details/5
        public ActionResult Details(int id)
        {
            var location = servicesClient.getAllLocations().Where(b => b.id == id).FirstOrDefault();
            return View(location);
        }

        // GET: Location/Create

        public ActionResult Create()
        {
            return View();
        }

        // POST: Location/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Location newLocation)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    servicesClient.AddLocation(newLocation);
                    return RedirectToAction("Index", "Location");
                }

                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Location/Edit/5
        public ActionResult Edit(int id)
        {
            var location = servicesClient.getAllLocations().Where(b => b.id == id).FirstOrDefault();
            return View(location);
        }

        // POST: Location/Edit/5
        [HttpPost]
        public ActionResult Edit(Location newLocation)
        {
            try
            {
                servicesClient.EditLocation(newLocation);
                // TODO: Add update logic here

                return RedirectToAction("Index","Location");
            }
            catch
            {
                return View();
            }
        }

        // GET: Location/Delete/5
        public ActionResult Delete(string id)
        {
            servicesClient.DeleteLocation(id);
            return View();
        }

        // POST: Location/Delete/5
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
    }
}
