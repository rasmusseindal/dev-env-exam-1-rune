using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Identity.Models
{
    public class UserProfession
    {
        public int UserProfessionId { get; set; }
        public string startLevel { get; set; }
        public string goalLevel { get; set; }
        public DateTime startDate { get; set; }

        //public int CompanyId { get; set; }
        //public virtual Company Company { get; set; }

        public string UserId { get; set; }        
        public virtual ApplicationUser User { get; set; }

        public int ProfessionId { get; set; }
        public virtual Profession Profession { get; set; }
    }
}