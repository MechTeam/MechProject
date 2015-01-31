using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuickDocs.Controllers
{
    public class AdminController : Controller
    {
        //
        // GET: /Admin/
                
        //[Authorize(Roles="SuperAdmin")]
        public ActionResult Index()
        {
            return View();
        }

    }
}
