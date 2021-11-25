using Inventario.Models.ViewModel;
using Inventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using static Inventario.Filters.authorizeUser;


namespace Inventario.Controllers
{
    public class CRUDController : Controller
    {
        // GET: CRUD
        #region Accesorios
        [AuthorizeUser(IdConsulta: 1)]
        public ActionResult AccesoriosIndex()
        {

            List<ListAccesoriosViewModel> lst;
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                lst = (from d in db.Accesorios
                       select new ListAccesoriosViewModel
                       {
                           Id = d.Id,
                           nombre = d.Nombre,

                           
                       }).ToList();
            }

            return View(lst);
            
        }
        
        [AuthorizeUser(IdConsulta: 2)]
        public ActionResult AgregarAccesorio()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AgregarAccesorio(AccesoriosViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (LoginExAndresEntities db = new LoginExAndresEntities())
                    {
                        var oAccesorio = new Accesorio();

                        oAccesorio.Nombre = model.nombre;
                        db.Accesorios.Add(oAccesorio);
                        
                        db.SaveChanges();
                    }
                   
                    return Redirect("~/CRUD/AccesoriosIndex/");
                }

                return View(model);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        [AuthorizeUser(IdConsulta: 2)]
        public ActionResult EditarAccesorio(int Id)
        {
            AccesoriosViewModel model = new AccesoriosViewModel();
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                var oAccesorio = db.Accesorios.Find(Id);
                model.nombre = oAccesorio.Nombre;
                
                model.Id = oAccesorio.Id;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult EditarAccesorio(AccesoriosViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (LoginExAndresEntities db = new LoginExAndresEntities())
                    {
                        var oAccesorio = db.Accesorios.Find(model.Id);
                        
                        oAccesorio.Nombre = model.nombre;

                        db.Entry(oAccesorio).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }

                    return Redirect("~/CRUD/AccesoriosIndex/");
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
        public JsonResult EliminarAccesorio(int Id)
        {
            bool status = false;
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {

                var oAccesorio = db.Accesorios.Find(Id);
                db.Accesorios.Remove(oAccesorio);
                db.SaveChanges();
                status = true;
            }
            return new JsonResult { Data = new { status } };
        }

        #endregion

        #region Marcas
        [AuthorizeUser(IdConsulta: 1)]
        public ActionResult MarcaIndex()
        {
            List<listMarcaViewModel> lst;
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                lst = (from d in db.Marcas
                       select new listMarcaViewModel
                       {
                           Id = d.Id,
                           nombre = d.Nombre

                   
                       }).ToList();
            }

            return View(lst);

        }

        [AuthorizeUser(IdConsulta: 2)]
        public ActionResult AgregarMarca()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AgregarMarca(MarcasViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (LoginExAndresEntities db = new LoginExAndresEntities())
                    {
                        var oMarca = new Marca();
                        oMarca.Nombre = model.nombre;
                        db.Marcas.Add(oMarca);
                        
                        
                        db.SaveChanges();
                    }

                    return Redirect("~/CRUD/MarcaIndex/");
                }

                return View(model);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        [AuthorizeUser(IdConsulta: 2)]
        public ActionResult EditarMarca(int Id)
        {
            MarcasViewModel model = new MarcasViewModel();
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                var oMarca = db.Marcas.Find(Id);
                model.nombre = oMarca.Nombre;

                model.Id = oMarca.Id;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult EditarMarca(MarcasViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (LoginExAndresEntities db = new LoginExAndresEntities())
                    {
                        var oMarca = db.Marcas.Find(model.Id);

                        oMarca.Nombre = model.nombre;

                        db.Entry(oMarca).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }

                    return Redirect("~/CRUD/MarcaIndex/");
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
        public JsonResult EliminarMarca(int Id)
        {
            bool status = false;
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {

                var oMarca = db.Marcas.Find(Id);
                db.Marcas.Remove(oMarca);
                db.SaveChanges();
                status = true;
            }
            return new JsonResult { Data = new { status } };
        }

        #endregion

        #region Modelos
        [AuthorizeUser(IdConsulta: 1)]
        public ActionResult ModeloIndex()
        {
            List<ListModeloViewModel> lst;
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                lst = (from d in db.Modeloes
                       select new ListModeloViewModel
                       {
                           Id = d.Id,
                           nombre = d.Nombre


                       }).ToList();
            }

            return View(lst);

        }

        [AuthorizeUser(IdConsulta: 2)]
        public ActionResult AgregarModelo()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AgregarModelo(ModelosViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (LoginExAndresEntities db = new LoginExAndresEntities())
                    {
                        var oModelo = new Modelo();
                        oModelo.Nombre = model.nombre;
                        db.Modeloes.Add(oModelo);


                        db.SaveChanges();
                    }

                    return Redirect("~/CRUD/ModeloIndex/");
                }

                return View(model);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        [AuthorizeUser(IdConsulta: 2)]
        public ActionResult EditarModelo(int Id)
        {
            ModelosViewModel model = new ModelosViewModel();
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                var oModelo = db.Modeloes.Find(Id);
                model.nombre = oModelo.Nombre;

                model.Id = oModelo.Id;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult EditarModelo(ModelosViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (LoginExAndresEntities db = new LoginExAndresEntities())
                    {
                        var oModelo = db.Modeloes.Find(model.Id);

                        oModelo.Nombre = model.nombre;

                        db.Entry(oModelo).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }

                    return Redirect("~/CRUD/ModeloIndex/");
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
        public JsonResult EliminarModelo(int Id)
        {
            bool status = false;
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {

                var oModelo = db.Modeloes.Find(Id);
                db.Modeloes.Remove(oModelo);
                db.SaveChanges();
                status = true;
            }

            return new JsonResult { Data = new { status } };
        }
        #endregion

        #region Monitor
        [AuthorizeUser(IdConsulta: 1)]
        public ActionResult MonitorIndex()
        {
            List<ListMonitorViewModel> lst;
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                lst = (from d in db.Monitors
                       select new ListMonitorViewModel
                       {
                           Id = d.Id,
                           marca = d.Marca,
                           serial = d.Serial,
                           modelo = d.Modelo,
                           tamaño = d.Tamaño,
                           cantidad = d.Cantidad

                       }).ToList();
            }

            return View(lst);

        }
        [AuthorizeUser(IdConsulta: 2)]
        public ActionResult AgregarMonitor()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AgregarMonitor(MonitorViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (LoginExAndresEntities db = new LoginExAndresEntities())
                    {
                        var oMonitor = new Monitor();
                        oMonitor.Marca = model.marca;
                        oMonitor.Serial = model.serial;
                        oMonitor.Modelo = model.modelo;
                        oMonitor.Tamaño = model.tamaño;
                        oMonitor.Cantidad = model.cantidad;
                        db.Monitors.Add(oMonitor);


                        db.SaveChanges();
                    }

                    return Redirect("~/CRUD/MonitorIndex/");
                }

                return View(model);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }

        [AuthorizeUser(IdConsulta: 2)]
        public ActionResult EditarMonitor(int Id)
        {
            MonitorViewModel model = new MonitorViewModel();
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                var oMonitor = db.Monitors.Find(Id);
                model.marca = oMonitor.Marca;
                model.serial = oMonitor.Serial;
                model.modelo = oMonitor.Modelo;
                model.tamaño = oMonitor.Tamaño;
                model.cantidad = oMonitor.Cantidad;

                model.Id = oMonitor.Id;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult EditarMonitor(MonitorViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (LoginExAndresEntities db = new LoginExAndresEntities())
                    {
                        var oMonitor = db.Monitors.Find(model.Id);

                        oMonitor.Marca = model.marca;
                       oMonitor.Serial = model.serial;
                        oMonitor.Modelo = model.modelo;
                        oMonitor.Tamaño = model.tamaño;
                        oMonitor.Cantidad = model.cantidad;
                        db.Entry(oMonitor).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }

                    return Redirect("~/CRUD/MonitorIndex/");
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
        public JsonResult EliminarMonitor(int Id)
        {
            bool status = false;
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {

                var oMonitor = db.Monitors.Find(Id);
                db.Monitors.Remove(oMonitor);
                db.SaveChanges();
                status = true;
            }
            return new JsonResult { Data = new { status } };
        }
        #endregion

        #region Empleados
        [AuthorizeUser(IdConsulta: 1)]
        public ActionResult EmpleadoIndex()
        {
            List<ListEmpleadoModelView> lst;
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                lst = (from d in db.Empleadoes
                       select new ListEmpleadoModelView
                       {
                           Id = d.Id,
                           nombre = d.Nombre,
                           codigo = d.Codigo,
                           posicion = d.Posicion,
                           direccion = d.Direccion,
                           localidad = d.Localidad

                       }).ToList();
            }

            return View(lst);

        }

        [AuthorizeUser(IdConsulta: 2)]
        public ActionResult AgregarEmpleado()
        {

            return View();
        }

        [HttpPost]
        public ActionResult AgregarEmpleado(EmpleadosViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (LoginExAndresEntities db = new LoginExAndresEntities())
                    {
                        var oEmp = new Empleado();
                        oEmp.Nombre = model.nombre;
                        oEmp.Codigo = model.codigo;
                        oEmp.Posicion = model.posicion;
                        oEmp.Direccion = model.direccion;
                        oEmp.Localidad = model.localidad;
                        db.Empleadoes.Add(oEmp);


                        db.SaveChanges();
                    }

                    return Redirect("~/CRUD/EmpleadoIndex/");
                }

                return View(model);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        [AuthorizeUser(IdConsulta: 2)]
        public ActionResult EditarEmpleado(int Id)
        {
            EmpleadosViewModel model = new EmpleadosViewModel();
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                var oEmp = db.Empleadoes.Find(Id);
                model.nombre = oEmp.Nombre;
                model.codigo = oEmp.Codigo;
                model.posicion = oEmp.Posicion;
                model.direccion = oEmp.Direccion;
                model.localidad = oEmp.Localidad;

                model.Id = oEmp.Id;
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult EditarEmpleado(EmpleadosViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (LoginExAndresEntities db = new LoginExAndresEntities())
                    {
                        var oEmp = db.Empleadoes.Find(model.Id);

                        oEmp.Nombre = model.nombre;
                        oEmp.Codigo = model.codigo;
                        oEmp.Posicion = model.posicion;
                        oEmp.Direccion = model.direccion;
                        oEmp.Localidad = model.localidad;
                        db.Entry(oEmp).State = System.Data.Entity.EntityState.Modified;
                        db.SaveChanges();
                    }

                    return Redirect("~/CRUD/EmpleadoIndex/");
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
        public JsonResult EliminarEmpleado(int Id)
        {
            bool status = false;
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                
                var oEmp = db.Empleadoes.Find(Id);
                db.Empleadoes.Remove(oEmp);
             
                db.SaveChanges();
                status = true;
            }
            return new JsonResult { Data = new { status } };
        }
        #endregion

        #region Equipo
        [AuthorizeUser(IdConsulta: 1)]
        public ActionResult EquipoIndex()
        {
            List<ListEquiposViewModel> lst;
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                lst = (from d in db.Equipoes.Include(e => e.Empleado).Include(m => m.Marca).Include(o=> o.Modelo).Include(n => n.Monitor).Include(a => a.Accesorio).Include(s => s.Asignacion)
                       select new ListEquiposViewModel
                       {
                           Id = d.Id,
                           Empleado = d.Empleado.Nombre,
                           empleadoId = d.EmpleadoId,
                           Marca =  d.Marca.Nombre,
                           marcaId = d.MarcaId,
                           procesador = d.Procesador,
                           memoria = d.Memoria,
                           disco = d.Disco,
                           Asignacion = d.Asignacion.Nombre,
                           asignacionId = d.AsignacionId,
                           serial = d.Serial,
                           Modelo = d.Modelo.Nombre,
                           modeloId = d.ModeloId,
                           Monitor = d.Monitor.Marca,
                           monitorId = d.MonitorId,
                           Accesorio = d.Accesorio.Nombre,
                           accesorioId = d.AccesorioId,
                         

                       }).ToList();
            }

            return View(lst);

        }

        [AuthorizeUser(IdConsulta: 2)]
        public ActionResult AgregarEquipo()
        {
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                ViewBag.marcaId = db.Marcas.ToList().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre });
                ViewBag.empleadoId = db.Empleadoes.ToList().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre });
                ViewBag.modeloId = db.Modeloes.ToList().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre });
                ViewBag.accesorioId = db.Accesorios.ToList().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre });
                ViewBag.asignacionId = db.Asignacions.ToList().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre });
                ViewBag.monitorId = db.Monitors.ToList().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Marca });
            }

            return View();
        }

        [HttpPost]
        public ActionResult AgregarEquipo(EquiposViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (LoginExAndresEntities db = new LoginExAndresEntities())
                    {
                        var oEquipo = new Equipo();
                        oEquipo.EmpleadoId = model.empleadoId;
                        oEquipo.MarcaId = model.marcaId;
                        oEquipo.ModeloId = model.modeloId;
                        oEquipo.MonitorId = model.monitorId;
                        oEquipo.AccesorioId = model.accesorioId;
                        oEquipo.Procesador = model.procesador;
                        oEquipo.Memoria = model.memoria;
                        oEquipo.Disco = model.disco;
                        oEquipo.AsignacionId = model.asignacionId;
                        oEquipo.Serial = model.serial;
                        oEquipo.Fcreacion = model.FCreacion;
                        //oEquipo.Factualizacion = model.fActualizacion;
                        oEquipo.Fdespacho = model.fDespacho;
                        db.Equipoes.Add(oEquipo);


                        db.SaveChanges();
                    }

                    
                        return Redirect("~/CRUD/EquipoIndex/");
                }

                using (LoginExAndresEntities db = new LoginExAndresEntities())
                {
                    ViewBag.marcaId = db.Marcas.ToList().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre });
                    ViewBag.empleadoId = db.Empleadoes.ToList().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre });
                    ViewBag.modeloId = db.Modeloes.ToList().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre });
                    ViewBag.accesorioId = db.Accesorios.ToList().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre });
                    ViewBag.asignacionId = db.Asignacions.ToList().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre });
                    ViewBag.monitorId = db.Monitors.ToList().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Marca });
                }


                return View(model);


            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }


        }
        [AuthorizeUser(IdConsulta: 2)]
        public ActionResult EditarEquipo(int Id)
        {
            EquiposViewModel model = new EquiposViewModel();
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                var oEquipo = db.Equipoes.Find(Id);
                model.empleadoId = oEquipo.EmpleadoId;
                model.marcaId = oEquipo.MarcaId;
                model.procesador = oEquipo.Procesador;
                model.memoria = oEquipo.Memoria;
                model.disco = oEquipo.Disco;
                model.asignacionId = oEquipo.AsignacionId;
                model.serial = oEquipo.Serial;
                model.modeloId = oEquipo.ModeloId;
                model.monitorId = oEquipo.MonitorId;
                model.accesorioId = oEquipo.AccesorioId;
                model.FCreacion = (DateTime)oEquipo.Fcreacion;
                model.fActualizacion = oEquipo.Factualizacion;
                model.fDespacho = oEquipo.Fdespacho;
                

                model.Id = oEquipo.Id;
            }

            var marcas = new List<Marca>();
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                marcas = db.Marcas.ToList();

            }

            ViewBag.marcaId = new SelectList(marcas, "Id", "Nombre", model.marcaId);

            var empleados = new List<Empleado>();
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                empleados = db.Empleadoes.ToList();

            }

            ViewBag.empleadoId = new SelectList (empleados, "Id", "Nombre", model.empleadoId );


            var modelos = new List<Modelo>();
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                modelos = db.Modeloes.ToList();

            }
            ViewBag.modeloId = new SelectList(modelos, "Id", "Nombre", model.modeloId);

            //ViewBag.modeloId = modelos.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre });

            var accesorios = new List<Accesorio>();
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                accesorios = db.Accesorios.ToList();

            }
            ViewBag.accesorioId = new SelectList(accesorios, "Id", "Nombre", model.accesorioId);

            //ViewBag.accesorioId = accesorios.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre });

            var monitor = new List<Monitor>();
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                monitor = db.Monitors.ToList();

            }
            ViewBag.monitorId = new SelectList(monitor, "Id", "Marca", model.monitorId);

            //ViewBag.monitorId = monitor.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Marca });

            var asignacion = new List<Asignacion>();
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {
                asignacion = db.Asignacions.ToList();

            }
            ViewBag.asignacionId = new SelectList(asignacion, "Id", "Nombre", model.asignacionId);

            //ViewBag.asignacionId = asignacion.Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre });

            return View(model);
        }

        [HttpPost]
        public ActionResult EditarEquipo(EquiposViewModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    using (LoginExAndresEntities db = new LoginExAndresEntities())
                    {
                        var oEquipo = db.Equipoes.Find(model.Id);

                        oEquipo.EmpleadoId = model.empleadoId;
                        oEquipo.MarcaId = model.marcaId;
                        oEquipo.Procesador = model.procesador;
                        oEquipo.Memoria = model.memoria;
                        oEquipo.Disco = model.disco;
                        oEquipo.AsignacionId = model.asignacionId;
                        oEquipo.Serial = model.serial;
                        oEquipo.ModeloId = model.modeloId;
                        oEquipo.MonitorId = model.monitorId;
                        oEquipo.AccesorioId = model.accesorioId;
                        oEquipo.Fcreacion = model.FCreacion;
                        oEquipo.Factualizacion = model.fActualizacion;
                        oEquipo.Fdespacho = model.fDespacho;
                        db.Entry(oEquipo).State = EntityState.Modified;
                        db.SaveChanges();
                    }

                    return Redirect("~/CRUD/EquipoIndex/");
                }

                using (LoginExAndresEntities db = new LoginExAndresEntities())
                {
                    ViewBag.marcaId = db.Marcas.ToList().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre });
                    ViewBag.empleadoId = db.Empleadoes.ToList().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre });
                    ViewBag.modeloId = db.Modeloes.ToList().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre });
                    ViewBag.accesorioId = db.Accesorios.ToList().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre });
                    ViewBag.asignacionId = db.Asignacions.ToList().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Nombre });
                    ViewBag.monitorId = db.Monitors.ToList().Select(x => new SelectListItem { Value = x.Id.ToString(), Text = x.Marca });
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
        public JsonResult EliminarEquipo(int Id)
        {
            bool status = false;
            using (LoginExAndresEntities db = new LoginExAndresEntities())
            {

                var oEquipo = db.Equipoes.Find(Id);
                db.Equipoes.Remove(oEquipo);
                db.SaveChanges();
                status = true;
            }
            return new JsonResult { Data = new { status } };
        }
        #endregion

    }
}