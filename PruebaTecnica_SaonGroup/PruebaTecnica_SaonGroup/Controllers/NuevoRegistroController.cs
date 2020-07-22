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
        
        public ActionResult Index( int idJob = -1, string JobTitle = "", string Description = "", DateTime? ExpiresAt = null)
        {
            if (idJob > 0)
            {
                ViewBag.Title = "Update Job";
                ViewBag.Message = "Save";
            }
            else
            {
                ViewBag.Title = "Register New Job";
                ViewBag.Message = "Accept";
            }
            return View();
        }
        
        [HttpPost]
        public ActionResult Registro(Job job)
        {
            PruebaTecnica_SaonGroup.Conection.Conection conection;

            try
            {
                conection = new PruebaTecnica_SaonGroup.Conection.Conection();
                if( job.idJob > 0)
                    conection.EjecutarConsultas(new PruebaTecnica_SaonGroup.Process.General().EditarRegistro(job));
                else
                    conection.EjecutarConsultas(new PruebaTecnica_SaonGroup.Process.General().CrearRegistro(job));
            }
            catch (Exception ex) { 
                
            }

            return RedirectToAction("Index", "Home"); 
        }
        [HttpPost]
        public ActionResult Edit(Job job)
        {

            return View();
        }
    }
}