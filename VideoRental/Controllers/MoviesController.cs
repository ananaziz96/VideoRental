﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VideoRental.Models;

namespace VideoRental.Controllers
{
    public class MoviesController : Controller
    {
        //GET: Movies/Random
        public ActionResult Index()
        {
            var movie = new Movie() { Name = "Shrek!" };
            return View (movie);
        }
    }
}
