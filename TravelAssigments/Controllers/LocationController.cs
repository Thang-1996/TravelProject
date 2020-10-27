using PagedList;
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
        public ViewResult Index(string sortOrder, string search, string currentFilter, int? page)
        {
            ViewBag.CurrentSort = sortOrder;
            ViewBag.NameSortParm = String.IsNullOrEmpty(sortOrder) ? "name_desc" : "";
            /*            ViewBag.listLocation = servicesClient.getAllLocations();
            */
            if (search != null)
            {
                page = 1; // nếu search có giá trị trả về page = 1
            }
            else
            {
                search = currentFilter; //  nếu có thì render phần dữ liệu search ra
            }
            ViewBag.CurrentFilter = search;
            var locations = from s in servicesClient.getAllLocations() select s;
            if (!String.IsNullOrEmpty(search)) // check nếu search string có thì in ra hoặc không thì không in ra
            {
                locations = locations.Where(s => s.LocationName.Contains(search) || s.LocationAddress.Contains(search)); // contains là để check xem lastname hoặc firstName có chứa search string ở trên 
            }
            switch (sortOrder)
            {
                case "name desc":
                    locations = locations.OrderByDescending(s => s.LocationName); // các case tương đương với các cột muốn sort
                    break;
              
                default:
                    locations = locations.OrderBy(s => s.LocationName);
                    break;
            }
           
            return View(locations.ToList());
            /*return View();*/
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
