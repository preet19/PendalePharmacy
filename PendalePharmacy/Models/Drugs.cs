using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PendalePharmacy.Models
{
    public class Drugs
    {
        
        
        public int DrugsID { get; set; }

        [Required]
        [Display (Name = "Drug Name")]
        public string drugName { get; set; }

        

    }
}