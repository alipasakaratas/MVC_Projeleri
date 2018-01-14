using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_MVC.Controllers
{
    using Models;
    public class EtiketController : Controller
    {
        SugarBlogContext context = new SugarBlogContext();
        // GET: Etiket
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult EtiketWidget() {

            return PartialView(context.Etikets.ToList());
        }
    }
}