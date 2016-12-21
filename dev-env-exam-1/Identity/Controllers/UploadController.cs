using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FileUpload.Controllers
{  
    public class UploadController : Controller
    {
        // GET: Upload  
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult UploadFile()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            var userId = User.Identity.GetUserId();
            try
            {
                if (file.ContentLength > 0)
                {
                    if (User.IsInRole("Admin"))
                    {
                        string _FileName = Path.GetFileName(file.FileName);
                        string _path = Path.Combine(Server.MapPath("~/CompanyImages"), userId+".jpg");
                        file.SaveAs(_path);
                    } else
                    {
                        string _FileName = Path.GetFileName(file.FileName);
                        string _path = Path.Combine(Server.MapPath("~/UserImages"), userId + ".jpg");
                        file.SaveAs(_path);
                    }                    
                }
                return RedirectToAction("UserIndex", "Manage");
            }
            catch
            {
                return RedirectToAction("UserIndex", "Manage");
            }
        }
    }  
}  