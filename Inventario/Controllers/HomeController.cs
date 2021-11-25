using Inventario.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static Inventario.Filters.authorizeUser;

namespace Inventario.Controllers
{
    public class HomeController : Controller
    {

        #region Index
        [AuthorizeUser(IdConsulta: 1)]
        public ActionResult Index()
        {
          
            return View();
        }

        //public ActionResult Clasificar()
        //{
        //    var yourVm = new ClasificarViewModel();
        //    yourVm.ShowHiddenLinks = true;

        //    return View(yourVm);
        //}
        #endregion

        [AuthorizeUser(IdConsulta: 2)]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [AuthorizeUser(IdConsulta: 2)]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

      
    }
}