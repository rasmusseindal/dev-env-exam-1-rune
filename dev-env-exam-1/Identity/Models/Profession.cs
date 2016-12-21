using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Identity.Models
{
    public class Profession
    {
        public int ProfessionId { get; set; }
        public string ProfessionName { get; set; }
        public string ProfessionDescription { get; set; }
        public int CompanyId { get; set; }
        public virtual Company Company { get; set; }

        public virtual ICollection<UserProfession> UserProfession { get; set; }

        public Profession()
        {

            this.UserProfession = new List<UserProfession>();
        }
    }
}