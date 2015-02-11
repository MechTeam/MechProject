using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuickDocs.Models.Domain.Entities;
using QuickDocs.Models.Domain.Providers;
using QuickDocs.Logic.WebTemplateObject;

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

        //[Authorize(Roles="SuperAdmin")]
        public ViewResult AdminPanel()
        {
            return View();
        }

        //[Authorize(Roles="SuperAdmin")]
        public ViewResult UserList()
        {
            try
            {
                UserProvider provider = new UserProvider();
                IList<UserWTO> users = new List<UserWTO>();

                foreach (User user in provider.GetList())
                {
                    users.Add(new UserWTO(user));
                }

                return View(users);
            }
            catch (Exception)
            {
                RedirectToAction("Error");
            }

            return View();
        }
    }
}
