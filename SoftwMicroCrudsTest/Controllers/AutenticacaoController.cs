using SoftwMicroCrudsTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;
using System.Web.Mvc;

namespace SoftwMicroCrudsTest.Controllers
{
    [AllowAnonymous]
    public class AutenticacaoController : Controller
    {
        
        [HttpGet]
        public ActionResult Login(string returnUrl)
        {
            var model = new LoginModel
            {
                ReturnUrl = returnUrl
            };

            return View(model);
        }

        [HttpPost]
        public ActionResult Login(LoginModel model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }

            if (model.Login == "manoelcontatosi@gmail.com" && model.Senha == "123")
            {
                var identity = new ClaimsIdentity(new[] {
                    new Claim(ClaimTypes.Name,"Manoel"),
                    new Claim(ClaimTypes.Email,"manoelcontatosi@gmail.com"),
                    new Claim(ClaimTypes.Email,"Brasil"),
                    new Claim(ClaimTypes.NameIdentifier, "userId")
                }, "ApplicationCookie");

                var ctx = Request.GetOwinContext();
                var authManager = ctx.Authentication;

                authManager.SignIn(identity);

                return Redirect(GetRedirectUrl(model.ReturnUrl));
            }
            return View();
        }

        private string GetRedirectUrl(string returnUrl)
        {
           if(string.IsNullOrEmpty(returnUrl) || !Url.IsLocalUrl(returnUrl))
            {
                return Url.Action("index", "home");
            }

            return returnUrl;
        }

        public ActionResult LogOut()
        {
            var ctx = Request.GetOwinContext();
            var authManager = ctx.Authentication;

            authManager.SignOut("ApplicationCookie");
        
            return RedirectToAction("index", "home");
        }
    }
}