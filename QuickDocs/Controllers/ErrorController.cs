using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuickDocs.Logic;

namespace QuickDocs.Controllers
{
    public class ErrorController : Controller
    {
        //
        // GET: /Error/

        public ActionResult Error()
        {
            String message = "";

            if (TempData["Message"] != null)
            {
                message = TempData["Message"].ToString();
            }
            else
            {
                message = MessageHelper.GetErrorDescription(MessageCode.ErrorNull);
            }

            ViewData["message"] = message;
            return View();
        }

    }
}
