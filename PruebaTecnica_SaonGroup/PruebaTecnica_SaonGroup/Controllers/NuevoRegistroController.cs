using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebaTecnica_SaonGroup.Models;

namespace PruebaTecnica_SaonGroup.Controllers
{
    public class NuevoRegistroController : Controller
    {
        // GET: NuevoRegistro
        public ActionResult Index()
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult CrearRegistro(Job job)
        {
            PruebaTecnica_SaonGroup.Conection.Conection conection;

            try
            {
                conection = new PruebaTecnica_SaonGroup.Conection.Conection();

                conection.EjecutarConsultas(new PruebaTecnica_SaonGroup.Process.General().CrearRegistro(job));
            }
            catch (Exception ex) { 
                
            }

            return RedirectToAction("Index");
        }
    }
}