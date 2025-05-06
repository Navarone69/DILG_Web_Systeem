using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DILG.Views.User
{
    public class UserController : Controller
    {
        // GET: User
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult SubmitReport()
        {

            return View();
        }

        [HttpPost]
        public ActionResult UploadFile(HttpPostedFileBase file)
        {
            var viewModel = new DatatablesViewModel();

            if (file != null && file.ContentLength > 0)
            {
                // Validate the file type
                if (!viewModel.IsValidFileType(file.FileName))
                {
                    ModelState.AddModelError("File", "Invalid file type. Please upload a PDF, Word, Excel, JPG, or PNG file.");
                    return View(); // Return to the view with the error
                }

                // Process the file (e.g., save it, etc.)
                // ...
            }

            return View();
        }
    }
}