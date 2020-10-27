using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelAssigments.Models;

namespace TravelAssigments.Controllers
{
    public class PostController : Controller
    {
        ServicesClient servicesClient = new ServicesClient();

        // GET: Post
        public ActionResult Index()
        {
            ViewBag.listPost = servicesClient.getAllPosts();
            return View();
        }

        // GET: Post/Details/5
        public ActionResult Details(int id)
        {
            var post = servicesClient.getAllPosts().Where(b => b.id == id).FirstOrDefault();

            return View(post);
        }

        // GET: Post/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Post/Create
        [HttpPost]
        public ActionResult Create(Post newPost)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    servicesClient.AddPost(newPost);
                    return RedirectToAction("Index", "Post");
                }
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Post/Edit/5
        public ActionResult Edit(int id)
        {
            var post = servicesClient.getAllPosts().Where(b => b.id == id).FirstOrDefault();

            return View(post);
        }

        // POST: Post/Edit/5
        [HttpPost]
        public ActionResult Edit(Post newPost)
        {
            try
            {
                // TODO: Add update logic here
                servicesClient.EditPost(newPost);

                return RedirectToAction("Index","Post");
            }
            catch
            {
                return View();
            }
        }

        // GET: Post/Delete/5
        public ActionResult Delete(string id)
        {
            servicesClient.DeletePost(id);
            return View();
        }

        // POST: Post/Delete/5
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
