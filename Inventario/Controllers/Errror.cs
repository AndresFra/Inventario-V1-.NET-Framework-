using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventario.Controllers
{
    public class ErrrorController : Controller
    {
        [HttpGet]
        public ActionResult UnauthorizedOperation(string operacion, string modulo, string msjeErrorException)
        {
            ViewBag.operacion = operacion;
            ViewBag.modulo = modulo;
            ViewBag.msjeErrorException = msjeErrorException;
            return View();
        }
    }
}