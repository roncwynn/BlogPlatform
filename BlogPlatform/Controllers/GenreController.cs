using BlogPlatform.Models;
using BlogPlatform.Repositories;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogPlatform.Controllers
{
    public class GenreController:Controller
    {


        IRepository<Genre> genreRepo;

        public GenreController(IRepository<Genre> otherRepo)
        {
            this.genreRepo = otherRepo;
        }



        public ViewResult Index()
        {
            //Use our repo that is on line 17
            var model = genreRepo.GetAll();
            return View(model);
        }

        public ViewResult Details(int id)
        {
            //Use our repo that is on line 17
            var model = this.genreRepo.GetById(id);
            return View(model);


        }



    }
}
