using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using QuickDocs.Models.Domain.Entities;
using QuickDocs.Models.Domain.Providers;
using QuickDocs.Models.Domain.Filters;
using QuickDocs.Logic;
using QuickDocs.Models.Exceptions;


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
				ModelState.AddModelError("login", "Это поле обязательно для заполнения");
			}
			if (String.IsNullOrEmpty(Password))
			{
				ModelState.AddModelError("password", "Это поле обязательно для заполнения");
			}
			UserProvider provider = new UserProvider();
			try
			{
				if (provider.UserIsExsist(Login, Password))
				{
					return RedirectToAction("Index", "Admin");
				}
			}
			catch(EntityNotExistException ex)
			{
				ModelState.AddModelError("validation", ex);
			}
			return View();
		} 

        [HttpPost]
        public ActionResult LoginValidation(String input)
        {            
            if (Request.IsAjaxRequest()) 
            {
                if (input.Length < 5)
                {
                    return Json(new { result = MessageHelper.GetErrorDescription(MessageCode.LoginSymbolQuantity) });
                }

                try
                {
                    AccountProvider provider = new AccountProvider();

                    IList<AuthenticationFilter> usersData = provider.GetListAuthentication();

                    if (usersData.Select(x => x.EMail == input).FirstOrDefault())
                    {
                        return Json(new { result = MessageHelper.GetErrorDescription(MessageCode.LoginIsExist) });
                    }
                }
                catch (Exception)
                {
                    return Json(new { result = MessageHelper.GetErrorDescription(MessageCode.InternalError) });
                }

                return Json(new { result = MessageHelper.GetErrorDescription(MessageCode.OK) });
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
                    return Json(new { result = MessageHelper.GetErrorDescription(MessageCode.PasswordSymbolQuantity) });
                }

                return Json(new { result = MessageHelper.GetErrorDescription(MessageCode.OK) });
            }

            return View();
        }
    }
}
