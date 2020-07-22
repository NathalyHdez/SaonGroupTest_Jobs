using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PruebaTecnica_SaonGroup.Process;
using PruebaTecnica_SaonGroup.Models;
using System.Data;

namespace PruebaTecnica_SaonGroup.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(int idJob = -1)
        {
            DataSet ds = new DataSet();
            PruebaTecnica_SaonGroup.Conection.Conection conection;
            conection = new PruebaTecnica_SaonGroup.Conection.Conection();
            JobModel pm = new JobModel();

            
            if (idJob > 0)
            {
                ds = conection.EjecutarConsultas(new General().EliminarRegistro(idJob));
            }
            ds = conection.EjecutarConsultas(new General().ConsultarRegistros());

            List<Job> jobs = new List<Job>();
            jobs = new AccesoDatos().ConvertDataTable<Job>(ds.Tables[0]);

            pm.Jobs = jobs;
            pm.TotalCount = pm.Jobs.Count();
            pm.TotalCount = (pm.TotalCount / pm.PageSize) - (pm.TotalCount % pm.PageSize == 0 ? 1 : 0);


            //else
            //{
            //    //conection.EjecutarConsultas("DELETE FROM Jobs; INSERT INTO Jobs (Job, JobTitle, Description, CreatedAt, ExpiresAt ) VALUES(1, '*', '****', '20200720', null)");
            //    //ds = conection.EjecutarConsultas("SELECT Job idJob, JobTitle, Description, /*strftime('%Y-%m-%d',CreatedAt)*/ CreatedAt, ExpiresAt, (SELECT MAX(idJob) FROM Jobs) MaxIdJob FROM Jobs");


            //}


            return View(pm);
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