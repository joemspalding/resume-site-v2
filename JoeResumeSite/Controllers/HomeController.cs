using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JoeResumeSite.Models;

namespace JoeResumeSite.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resume()
        {
            ResumeViewModel model = new ResumeViewModel(); // constructor
            model.Path = "/Resources/RESUME.pdf";
            model.MimeType = "application/pdf";
            return View(model);
        }

        public ActionResult Contact()
        {
            return View();
        }

        public PartialViewResult ContactInfoPartial(ContactInfoViewModel model)
        {
            return PartialView(model);
        }
    }
}