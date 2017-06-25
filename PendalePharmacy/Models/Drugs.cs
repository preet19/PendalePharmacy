namespace PendalePharmacy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Drugs
    {
        [Key]
        public int DrugsID { get; set; }

        [Required]
        [Display(Name = "Drug Name")]
        public string drugName { get; set; }
    }
}
