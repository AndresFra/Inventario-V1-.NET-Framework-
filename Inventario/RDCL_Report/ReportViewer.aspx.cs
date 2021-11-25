using Inventario.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.Entity;
using Inventario.Models.ViewModel;

namespace Inventario.RDCL_Report
{
    public partial class ReportViewer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.PathInfo != null)
                {
                    int id = int.Parse(Request.PathInfo.Replace("/", string.Empty));

                    List<SalidaEquipo> lst = new List<SalidaEquipo>();
                    using (LoginExAndresEntities db = new LoginExAndresEntities())
                    {
                        var equipo = db.Equipoes.Include(em => em.Empleado).Include(m => m.Marca).Include(o => o.Modelo).Include(n => n.Monitor).Include(a => a.Accesorio).Include(s => s.Asignacion).FirstOrDefault(x => x.Id == id);
                        //insertar salida equipo
                        var salidaEquipo = db.SalidaEquipoes.Add(new SalidaEquipo
                        {
                            Empleado = equipo.Empleado.Nombre,
                            Marca = equipo.Marca.Nombre,
                            Modelo = equipo.Modelo.Nombre,
                            Serial = equipo.Serial,
                            FechaDespacho = DateTime.Now,
                            EquipoId = equipo.Id
                        });

                        db.SaveChanges();

                        lst.Add(salidaEquipo);
                        
                    }

                    string path = Server.MapPath("~/RDCL_Report/ReportEquipo.rdlc");
                    reportviewerEquipo.LocalReport.ReportPath = path;
                    reportviewerEquipo.LocalReport.DataSources.Clear();
                    reportviewerEquipo.LocalReport.DataSources.Add(new Microsoft.Reporting.WebForms.ReportDataSource("DataSetEquipo", lst));
                    reportviewerEquipo.DataBind();
                }
            }

        }
    }
}