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
        public ActionResult NotFound()
        {
            Response.StatusCode = (int)HttpStatusCode.NotFound;

            return View();
        }

        public ActionResult InternalError()
        {
            Response.StatusCode = (int)HttpStatusCode.InternalServerError;

            return View();
        }
    }
}