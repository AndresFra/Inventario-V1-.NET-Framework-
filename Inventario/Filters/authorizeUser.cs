using Inventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Inventario.Filters
{
    public class authorizeUser
    {
        [AttributeUsage(AttributeTargets.Method, AllowMultiple = false)]
        public class AuthorizeUser : AuthorizeAttribute
        {
            private usuario oUsuario;
            private LoginExAndresEntities db = new LoginExAndresEntities();
            private int IdConsulta;

            public AuthorizeUser(int IdConsulta = 0)
            {
                this.IdConsulta = IdConsulta;
            }

            public override void OnAuthorization(AuthorizationContext filterContext)
            {
                string nombreOperacion = "";
                string nombreModulo = "";
                try
                {
                    oUsuario = (usuario)HttpContext.Current.Session["Usuario"];
                    var lstMisOperaciones = from m in db.RolAdmins
                                            where m.IdRol == oUsuario.IdRol
                                            && m.IdConsulta == IdConsulta
                                            select m;
                    if (lstMisOperaciones.ToList().Count() == 0)
                    {
                        var Oconsulta = db.RolConsultas.Find(IdConsulta);
                        int? IdModulo = Oconsulta.IdModulo;
                        nombreOperacion = GetNombreDeOperacion(IdConsulta);
                        nombreModulo = getNombreDelModulo(IdModulo);
                        filterContext.Result = new RedirectResult("~/acceso/Login" /*+ nombreOperacion*/);

                    }
                }
                catch (Exception)
                {
                    filterContext.Result = new RedirectResult("~/Errror/UnauthorizedOperation?operacion=" /*+ nombreOperacion*/);

                }


            }



            public string GetNombreDeOperacion(int idConsulta)
            {
                var ope = from op in db.RolConsultas
                          where op.Id == IdConsulta
                          select op.Nombre;
                string nombreOperacion;
                try
                {
                    nombreOperacion = ope.First();
                }
                catch (Exception)
                {

                    nombreOperacion = "";
                }
                return nombreOperacion;
                //throw new NotImplementedException();
            }

            public string getNombreDelModulo(int? idModulo)
            {
                var modulo = from m in db.moduloes
                             where m.Id == idModulo
                             select m.Nombre;
                string nombreModulo;
                try
                {
                    nombreModulo = modulo.First();
                }
                catch (Exception)
                {

                    nombreModulo = "";
                }
                return nombreModulo;

                //throw new NotImplementedException();
            }
        }
    }
}