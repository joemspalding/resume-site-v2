using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace JoeResumeSite.Controllers
{
    public class ErrorController : Controller
    {
        //consolodate the views
        public ActionResult NotFound()
        {
            Response.StatusCode = (int)HttpStatusCode.NotFound;

            ViewBag.Title = "404 - Page Not Found";
            ViewBag.Message = "Whoops! Looks like you're trying to go to a page that doesn't exist";

            return View("Error");
        }

        public ActionResult InternalError()
        {
            ViewBag.Title = "500 - Internal Server Error";
            ViewBag.Message = "Oh noes! I don't have a good enough server to handle all of these requests";
            Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            return View("Error");
        }
    }
}