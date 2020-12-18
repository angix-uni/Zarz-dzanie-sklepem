using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjektZaliczenie.Models;

namespace ProjektZaliczenie.Controllers
{
    public class HomeController : Controller
        {
            // GET: Home
            public ActionResult Index()
            {
                return View();
            }
        }
    
}