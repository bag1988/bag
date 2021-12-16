using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace bag.Areas.Admin.Controllers
{
    public class RedactorController : Controller
    {
        // GET: Admin/Redactor
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult adminPanel()
        {
            return PartialView();
        }
        
    }
}