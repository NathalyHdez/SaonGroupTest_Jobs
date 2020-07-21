using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PruebaTecnica_SaonGroup.Models
{
    public class JobModel
    {
        public int PageNumber { set; get; }
        public int PageSize { set; get; }
        public int TotalCount { set; get; }
        public int PagerCount { set; get; }
        public virtual ICollection<Job> Jobs { get; set; }
        public JobModel() {
            this.PageNumber = 1;
            this.PageSize = 4;
        }
    }
}