using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GeoProfs.Models
{
    public class Verlof_reden : Person
    {
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    [Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return LastName + ", " + FirstMidName;
            }
        }      
    }
}
