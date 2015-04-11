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
			const string loginErrorName = "login";
			const string passwordErrorName = "password";
			const string validationErrorName="validetion";

			if (String.IsNullOrEmpty(Login))
			{
				ModelState.AddModelError(loginErrorName,MessageHelper.GetErrorDescription(MessageCode.LoginNull) );
			}
			if (String.IsNullOrEmpty(Password))
			{
				ModelState.AddModelError(passwordErrorName,MessageHelper.GetErrorDescription(MessageCode.PasswordNull));
			}

			AccountProvider provider = new AccountProvider();
			if (provider.LoginAndPasswordIsCorrect(Login, Password))
			{
				return RedirectToAction("Index", "Admin");
			}
			else
			{
				ModelState.AddModelError(validationErrorName,MessageHelper.GetErrorDescription(MessageCode.ValidationError));
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
