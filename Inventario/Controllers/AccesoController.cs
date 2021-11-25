using Inventario.Models;
using Inventario.Models.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using static Inventario.Filters.authorizeUser;

namespace Inventario.Controllers
{
    public class AccesoController : Controller
    {
        #region Login
        // GET: Acceso
        public ActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string User, string pass)
        {
            try
            {
                using (Models.LoginExAndresEntities db = new Models.LoginExAndresEntities())
                {
                    var oUser = (from d in db.usuarios
                                 where d.email == User.Trim() && d.password == pass.Trim()
                                 select d).FirstOrDefault();

                    if (oUser == null)
                    {
                        ViewBag.error = "Usuario o contraseña incorrecta.";
                        return View();
                    }

                    Session["Usuario"] = oUser;

                }

                return RedirectToAction("Index", "Home");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }

       
        }
        #endregion
        [AuthorizeUser(IdConsulta: 2)]
        public ActionResult UsuarioIndex()
        {
            List<ListUsuarios> lst;
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                lst = (from d in db.usuarios.Include(o => o.Rol)
                       select new ListUsuarios
                       {
                           Id = d.Id,
                           usuario = d.Usuario1,
                           Email = d.email,
                           Rol = d.Rol.Nombre,
                           idRol = d.IdRol



                       }).ToList();
            }

            return View(lst);

        }


        [AuthorizeUser(IdConsulta: 2)]
        public ActionResult AgregarUsuario()
        {
            var rol = new List<Rol>();
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                rol = db.Rols.ToList();

            }

            ViewBag.idRol = rol.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre });



            return View();
        }

        [HttpPost]
        public ActionResult AgregarUsuario(UsuariosViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (LoginExAndresEntities db = new LoginExAndresEntities())
                    {
                        var oUsuario = new usuario();
                        oUsuario.Usuario1 = model.usuario;
                        oUsuario.email = model.Email;
                        oUsuario.password = model.Password;
                        oUsuario.IdRol = model.idRol;
                        
                        db.usuarios.Add(oUsuario);


                        db.SaveChanges();
                    }


                    return Redirect("~/Acceso/UsuarioIndex/");
                }

                return View(model);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        [AuthorizeUser(IdConsulta: 2)]
        [HttpPost]
        public JsonResult EliminarUsuario(int Id)
        {
            bool status = false;
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                

                var oUsuario = db.usuarios.Find(Id);
                db.usuarios.Remove(oUsuario);
                db.SaveChanges();
                status = true;
            }
            return new JsonResult { Data = new { status } };
        }

    }
}