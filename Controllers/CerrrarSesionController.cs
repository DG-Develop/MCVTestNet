using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CursoMVC.Controllers
{
    public class CerrrarSesionController : Controller
    {
        // GET: CerrrarSesion
        public ActionResult Logout()
        {
            Session["User"] = null;
            return RedirectToAction("Index", "Access");
        }
    }
}