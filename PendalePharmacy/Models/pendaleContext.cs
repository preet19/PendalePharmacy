using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PendalePharmacy.Models
{
    public class pendaleContext: DbContext
    {

        public virtual DbSet<Drugs> Drugs { get; set; }
       

        
    }
}