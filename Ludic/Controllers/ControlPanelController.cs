using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ludic.Controllers
{
    public class ControlPanelController : Controller
    {
		// GET: ControlPanel
		[Authorize(Roles = "Administrator")]
		public ActionResult Index()
        {
            return View();
        }

		[HttpPost]
		public ActionResult UploadFiles(IEnumerable<HttpPostedFileBase> files,string subfolder)
		{
			foreach (var file in files)
			{
				DateTime time = DateTime.Now;
				string filePath = time.ToString("yyyy-MM-dd") + "-"+ Guid.NewGuid() + Path.GetExtension(file.FileName);
				file.SaveAs(Path.Combine(Server.MapPath("~/UploadedFiles"+"/"+subfolder),filePath));
				//Here you can write code for save this information in your database if you want
			}
			return Json("file uploaded successfully");
		}

	}
}