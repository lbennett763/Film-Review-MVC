﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FilmReview_MVC_Website.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Film Review application description page";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Our contact page";

            return View();
        }
    }
}