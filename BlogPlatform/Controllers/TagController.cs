using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlogPlatform.Models;
using BlogPlatform.Repositories;
using Microsoft.AspNetCore.Mvc;


namespace BlogPlatform.Controllers
{
    public class TagController : Controller
    {
        IRepository<Tag> TagRepo;

        public TagController(IRepository<Tag> tagRepo)
        {
            this.TagRepo = tagRepo;
        }

        public ViewResult Index()
        {
            var model = TagRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            var model = this.TagRepo.GetById(id);
            return View(model);
        }
    }
}
