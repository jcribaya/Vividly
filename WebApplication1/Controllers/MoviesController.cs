﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vividly.Models;

namespace WebApplication1.Controllers
{
    public class MoviesController : Controller
    {
        // GET: Random Movies
        public ActionResult Random()
        {
            var movie = new Movie() { Name = "Sherk" };
            return View();
        }
    }
}