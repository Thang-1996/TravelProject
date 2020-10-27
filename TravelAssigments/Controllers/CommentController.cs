using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelAssigments.Models;

namespace TravelAssigments.Controllers
{
    public class CommentController : Controller
    {
        ServicesClient servicesClient = new ServicesClient();

        // GET: Comment
        public ActionResult Index()
        {
            ViewBag.listComment = servicesClient.getAllComments();
            return View();
        }

        // GET: Comment/Details/5
        public ActionResult Details(int id)
        {
            var comment = servicesClient.getAllComments().Where(b => b.id == id).FirstOrDefault();

            return View(comment);
        }

        // GET: Comment/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Comment/Create
        [HttpPost]
        public ActionResult Create(Comment newComment)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    servicesClient.AddComment(newComment);
                    return RedirectToAction("Index", "Comment");
                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Comment/Edit/5
        public ActionResult Edit(int id)
        {
            var comment = servicesClient.getAllComments().Where(b => b.id == id).FirstOrDefault();

            return View(comment);
        }

        // POST: Comment/Edit/5
        [HttpPost]
        public ActionResult Edit(Comment newComment)
        {
            try
            {
                servicesClient.EditComment(newComment);

                // TODO: Add update logic here

                return RedirectToAction("Index","Comment");
            }
            catch
            {
                return View();
            }
        }

        // GET: Comment/Delete/5
        public ActionResult Delete(string id)
        {
            servicesClient.DeleteComment(id);

            return View();
        }

        // POST: Comment/Delete/5
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
