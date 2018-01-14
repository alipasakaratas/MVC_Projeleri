using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Blog_MVC.Controllers
{
    using Models;
    public class KategoriController : Controller
    {
        SugarBlogContext context = new SugarBlogContext();
        // GET: Kategori
        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult KategoriWidget() {

            return PartialView(context.Kategoris.ToList());
        }
    }
}