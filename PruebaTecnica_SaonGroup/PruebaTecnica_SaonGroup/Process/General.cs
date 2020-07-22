using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PruebaTecnica_SaonGroup.Models;

namespace PruebaTecnica_SaonGroup.Process
{
    public class General
    {
        public string ConsultarRegistros() { 
            string SqlQuery = "";

            SqlQuery = "SELECT Job idJob, JobTitle, Description, /*strftime('%Y-%m-%d',CreatedAt)*/ CreatedAt, ExpiresAt FROM Jobs";

            return SqlQuery;
        }
        public string CrearRegistro(Job job) {
            string SqlQuery = "";

            string ExpiredAt = "null";

            if (job.ExpiresAt.HasValue)
                ExpiredAt = "'" + job.ExpiresAt.Value.ToString("yyyyMMdd") + "'";


            SqlQuery = "INSERT INTO Jobs (Job, JobTitle, Description, CreatedAt, ExpiresAt ) " +
                        "SELECT ifnull((SELECT MAX(Job) FROM Jobs), 0) + 1, '@JobTitle', '@JobDescription', '@CreatedAt', @ExpiredAt";

            SqlQuery = SqlQuery.Replace("@JobTitle", job.JobTitle);
            SqlQuery = SqlQuery.Replace("@JobDescription", job.Description);
            SqlQuery = SqlQuery.Replace("@CreatedAt", DateTime.Now.ToString("yyyyMMdd"));
            SqlQuery = SqlQuery.Replace("@ExpiredAt", ExpiredAt);

            return SqlQuery;
        }

        public string EditarRegistro(Job job) {
            string SqlQuery = "";

            string ExpiredAt = "null";

            if (job.ExpiresAt.HasValue)
                ExpiredAt = "'" + job.ExpiresAt.Value.ToString("yyyyMMdd") + "'";


            SqlQuery = "UPDATE Jobs SET JobTitle = '@JobTitle', Description = '@JobDescription', ExpiresAt = @ExpiresAt WHERE Job = @Job ";

            SqlQuery = SqlQuery.Replace("@JobTitle", job.JobTitle);
            SqlQuery = SqlQuery.Replace("@JobDescription", job.Description);
            SqlQuery = SqlQuery.Replace("@ExpiresAt", ExpiredAt);
            SqlQuery = SqlQuery.Replace("@Job", job.idJob.ToString());

            return SqlQuery;
        }

        public string EliminarRegistro(int idJob)
        {
            string SqlQuery = "";

            SqlQuery = "DELETE FROM Jobs WHERE Job = @Job ";
            SqlQuery = SqlQuery.Replace("@Job", idJob.ToString());

            return SqlQuery;
        }
    }
}