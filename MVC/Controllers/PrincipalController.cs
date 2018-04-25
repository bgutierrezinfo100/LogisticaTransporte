using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class PrincipalController : Controller
    {
        // GET: Principal
        public ActionResult vwPrincipal()
        {
            return View();
        }

        public ActionResult PaginaPrincipal()
        {
            return View();
        }
    }
}