using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuickDocs.Models.Domain.Entities;
using QuickDocs.Models.Domain.Providers;
using QuickDocs.Models.Domain.Filters;
using QuickDocs.Logic;


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
        public ActionResult Index(String Login, String Password)
        {
            if (String.IsNullOrEmpty(Login))
            {
                ModelState.AddModelError("LoginMessage", "Заполните поле");
            }

            if (String.IsNullOrEmpty(Password))
            {
                ModelState.AddModelError("PasswordMessage", "Заполните поле");
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Admin");
            }

            return View();

        }

        [HttpPost]
        public ActionResult LoginValidation(String input)
        {            
            if (Request.IsAjaxRequest()) 
            {
                if (input.Length <= 5)
                {
                    return Json(new { result = MessageHelper.GetMessageDescription(MessageCode.LoginSymbolQuantity) });
                }

                return Json(new { result = MessageHelper.GetMessageDescription(MessageCode.OK) });
            }

            return View();
        }

        [HttpPost]
        public ActionResult PasswordValidation(String input)
        {
            if (Request.IsAjaxRequest())
            {
                if (input.Length < 5)
                {
                    return Json(new { result = MessageHelper.GetMessageDescription(MessageCode.PasswordSymbolQuantity) });
                }

                return Json(new { result = MessageHelper.GetMessageDescription(MessageCode.OK) });
            }

            return View();
        }
    }
}
