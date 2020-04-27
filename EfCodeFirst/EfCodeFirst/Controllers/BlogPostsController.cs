using EfCodeFirst.Models;
using EfCodeFirst.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EfCodeFirst.Controllers
{
    public class BlogPostsController : Controller
    {
        BlogPostRepository repository;

        public BlogPostsController()
        {
            repository = new Services.BlogPostRepository();
        }

        // GET: BlogPosts
        public ActionResult Index()
        {
            var posts = repository.ObtenerTodos();
            var comentarios = posts.First().Comentarios;
            return View(posts);
        }

        // GET: BlogPosts/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BlogPosts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BlogPosts/Create
        [HttpPost]
        public ActionResult Create(BlogPost model)
        {
            try
            {
                if (ModelState.IsValid)
                {                       
                    repository.Crear(model);
                    
                    return RedirectToAction("Index");
                }
            }
            catch (Exception ex)
            {
                //log
            }
            return View(model);
        }

        // GET: BlogPosts/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BlogPosts/Edit/5
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

        // GET: BlogPosts/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BlogPosts/Delete/5
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
