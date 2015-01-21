using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuickDocs.Controllers
{
    public class AuthController : Controller
    {
        //
        // GET: /Auth/
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(String login, String password)
        {
            throw new Exception();
        }

    }
}
