using Microsoft.VisualBasic;
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Geoprofs_v2.Models
{
    public enum status 
    {
        pending,      //0
        approved,  //1
        denied   //2
    }

    //public enum reden { 
    //    sick,
    //    personal,
    //    vacation,
    //    other
    //}

    public class VerlofAanvraag
    {
        [Key]
        public int verlof_id { get; set; }

        [ForeignKey("Werknemer")]
        public int werknemer_id { get; set; }

        [ForeignKey("VerlofReden")]
        public reden verlofReden { get; set; }

        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }
        public string description { get; set; }
        public status verlofStatus { get; set; }

    }
}
