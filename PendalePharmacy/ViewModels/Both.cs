using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PendalePharmacy.ViewModels
{
    public class Both
    {
        public IEnumerable<PendalePharmacy.Models.Faq> Faq { get; set; }
        public PendalePharmacy.Models.Faq Faq1 { get; set; }
    }
}