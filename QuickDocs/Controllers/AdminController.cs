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
            return View(new RoleWTO());
        }

        //[Authorize(Roles="SuperAdmin")]
        public ActionResult UserList()
        {
            try
            {
                UserProvider provider = new UserProvider();
                var us = provider.GetList();
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

        public ActionResult EditUser()
        {
            return View();
        }        

        [HttpPost]
        public PartialViewResult GetUserListByCategory(String category)
        {
            if (Request.IsAjaxRequest())
            {
                try
                {                    
                    UserProvider provider = new UserProvider();
                    IList<User> userData = provider.GetList();                    

                    userData = userData.Where(x => x.Roles.First<Role>().Name == category).ToList();

                    return PartialView("UserList", UserWTO.getUserListWTO(userData));
            
                }
                catch (Exception ex)
                {
                    RedirectToAction("Error");
                }
            }

            return PartialView("UserList");
        }

        [HttpGet]
        public PartialViewResult GetAllUsers()
        {
            if (Request.IsAjaxRequest())
            {
                try
                {                    
                    return PartialView("UserList", UserWTO.getUserListWTO(new UserProvider().GetList()));
                }
                catch(Exception ex)
                {
                    RedirectToAction("Error");
                }
            }

            return PartialView("UserList");
        }

        [HttpGet]
        public ViewResult AddAdmin()
        {
            return View();
        }

        [HttpPost]
        public RedirectToRouteResult AddAdmin(UserWTO p_admin)
        {
            try
            {
                
            }
            catch (Exception ex)
            {
                RedirectToAction("Error");
            }

            return RedirectToAction("Index");
        }

    }
}
