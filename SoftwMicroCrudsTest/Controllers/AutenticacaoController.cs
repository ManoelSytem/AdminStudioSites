using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SoftwMicroCrudsTest.Controllers
{
    [AllowAnonymous]
    public class AutenticacaoController : Controller
    {
        // GET: Autenticacao
        public ActionResult Login()
        {
            return View();
        }
    }
}