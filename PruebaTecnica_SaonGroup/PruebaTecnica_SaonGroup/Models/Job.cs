using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaTecnica_SaonGroup.Models
{
    public class Job
    {
        public int idJob { set; get; }
        public string JobTitle { set; get; }
        public string Description { set; get; }
        public DateTime CreatedAt { set; get; }
        public DateTime? ExpiresAt { set; get; }
        public Job() {
            //this.CreatedAt = new DateTime();
            //this.ExpiresAt = new DateTime();
        }
        //Getters
        //public int getIdJob() {
        //    return this.idJob;
        //}

        //public string getJobTitle()
        //{
        //    return this.JobTitle;
        //}

        //public string getDescription()
        //{
        //    return this.Description;
        //}

        //public string getCreatedAt()
        //{
        //    return this.CreatedAt;
        //}

        //public string getExpiresAt()
        //{
        //    return this.ExpiresAt;
        //}


        //// Setters
        //public void setIdJob(int idJob)
        //{
        //    this.idJob = idJob;
        //}

        //public void setJobTitle(string JobTitle)
        //{
        //    this.JobTitle = JobTitle;
        //}

        //public void setDescription(string Description)
        //{
        //    this.Description = Description;
        //}

        //public void setCreatedAt(string CreatedAt)
        //{
        //    this.CreatedAt = CreatedAt;
        //}

        //public void getExpiresAt(string ExpiresAt)
        //{
        //    this.ExpiresAt = ExpiresAt;
        //}
    }
}