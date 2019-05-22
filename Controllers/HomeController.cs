using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MEIWebsite2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Contacts()
        {
            return View();
        }

        public ActionResult AltContacts()
        {
            return View();
        }

        public ActionResult Artists()
        {
            return View();
        }

        public ActionResult Albums()
        {
            return View();
        }

        public ActionResult Requests()
        {
            return View();
        }
    }
}