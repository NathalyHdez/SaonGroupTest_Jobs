using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebaTecnica_SaonGroup.Conection;
using System.Data;

namespace PruebaTecnica_SaonGroup.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            DataSet ds = new DataSet();
            PruebaTecnica_SaonGroup.Conection.Conection conection;
            conection = new PruebaTecnica_SaonGroup.Conection.Conection();
            ds = conection.EjecutarConsultas("SELECT Job, JobTitle, Description, CreatedAt, ExpiresAt FROM Jobs");
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}