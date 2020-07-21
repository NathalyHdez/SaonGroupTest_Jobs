using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaTecnica_SaonGroup.Models
{
    public class Job
    {
        private int idJob;
        private string JobTitle;
        private string Description;
        private DateTime CreatedAt;
        private DateTime ExpiresAt;
        
        //Getters
        public int getIdJob() {
            return this.idJob;
        }

        public string getJobTitle()
        {
            return this.JobTitle;
        }

        public string getDescription()
        {
            return this.Description;
        }

        public DateTime getCreatedAt()
        {
            return this.CreatedAt;
        }

        public DateTime getExpiresAt()
        {
            return this.ExpiresAt;
        }


        // Setters
        public void setIdJob(int idJob)
        {
            this.idJob = idJob;
        }

        public void setJobTitle(string JobTitle)
        {
            this.JobTitle = JobTitle;
        }

        public void setDescription(string Description)
        {
            this.Description = Description;
        }

        public void setCreatedAt(DateTime CreatedAt)
        {
            this.CreatedAt = CreatedAt;
        }

        public void getExpiresAt(DateTime ExpiresAt)
        {
            this.ExpiresAt = ExpiresAt;
        }
    }
}