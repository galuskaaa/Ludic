using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ludic.Controllers
{
    public class ContentController : Controller
    {
        // GET: Content
        public ActionResult Index()
        {
            return View();
        }

		public ActionResult Portrait()
		{
			return View();
		}

		public ActionResult Street()
		{
			return View();
		}

		public ActionResult Events()
		{
			return View();
		}
	}
}