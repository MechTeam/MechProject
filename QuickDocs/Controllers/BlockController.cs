using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuickDocs.Controllers
{
    public class BlockController : Controller
    {
        //
        // GET: /Header/

        public ActionResult Header()
        {
            return View();
        }

        public ViewResult Footer()
        {
            return View();
        }

    }
}
