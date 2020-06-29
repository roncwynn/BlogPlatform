using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogPlatform.Models;
using BlogPlatform.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace BlogPlatform.Controllers
{
public class ContentController:Controller
    {
        IRepository<Content> ContentRepo;

        public ContentController(IRepository<Content> contentRepo)
        {
            this.ContentRepo = contentRepo;
        }

        public ViewResult Index()
        {
            var model = ContentRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = this.ContentRepo.GetById(id);
            return View(model);
        }

        [HttpGet]
        public ViewResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(Content content)
        {
             if (ModelState.IsValid)
             {
                content.PublishDate = DateTime.Now;
                ContentRepo.Create(content);
                return RedirectToAction("Details", "Genre", new { id = content.GenreId });
            }
            return View(content);
        }

        [HttpGet]
        public ViewResult CreateByGenreID(int Id)
        {
            ViewBag.GenreId = Id;
            return View();
        }

        [HttpGet]
        public ViewResult Delete(int id)
        {
            Content content = ContentRepo.GetById(id);
            return View(content);
        }
        [HttpPost]
        public ActionResult Delete(Content content)
        {
            int genreId = content.GenreId;
            ContentRepo.Delete(content);
            return RedirectToAction("Details", "Genre", new { id = genreId });
        }
        [HttpGet]
        public ViewResult Update(int id)
        {
            Content content = ContentRepo.GetById(id);
            return View(content);
        }
        [HttpPost]
        public ActionResult Update(Content content)
        {
            content.PublishDate = DateTime.Now;

            if (ModelState.IsValid)
            {
                content.PublishDate = DateTime.Now;
                int genreId = content.GenreId;
                content.ContentTags.Clear();
                ContentRepo.Update(content);
                return RedirectToAction("Details", "Genre", new { id = genreId });
            }
            return View(content);
        }
    }
}
