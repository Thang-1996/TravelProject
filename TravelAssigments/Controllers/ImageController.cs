using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelAssigments.Models;

namespace TravelAssigments.Controllers
{
    public class ImageController : Controller
    {
        ServicesClient servicesClient = new ServicesClient();

        // GET: Image
        public ActionResult Index()
        {
            ViewBag.listImage = servicesClient.getAllImages();

            return View();
        }

        // GET: Image/Details/5
        public ActionResult Details(int id)
        {
            var image = servicesClient.getAllImages().Where(b => b.id == id).FirstOrDefault();

            return View(image);
        }

        // GET: Image/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Image/Create
        [HttpPost]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Image newImage)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    servicesClient.AddImage(newImage);
                    return RedirectToAction("Index", "Image");
                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Image/Edit/5
        public ActionResult Edit(int id)
        {
            var image = servicesClient.getAllImages().Where(b => b.id == id).FirstOrDefault();

            return View(image);
        }

        // POST: Image/Edit/5
        [HttpPost]
        public ActionResult Edit(Image newImage)
        {
            try
            {
                servicesClient.EditImage(newImage);

                // TODO: Add update logic here

                return RedirectToAction("Index","Image");
            }
            catch
            {
                return View();
            }
        }

        // GET: Image/Delete/5
        public ActionResult Delete(string id)
        {
            servicesClient.DeleteImage(id);

            return View();
        }

        // POST: Image/Delete/5
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
