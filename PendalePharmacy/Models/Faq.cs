namespace PendalePharmacy.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Faq
    {
        [Key]
        public int FaqID { get; set; }

        [Required]
        public string comments { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string email { get; set; }
    }
}
