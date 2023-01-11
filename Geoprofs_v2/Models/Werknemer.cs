using System.ComponentModel.DataAnnotations;

namespace Geoprofs_v2.Models
{
    public class Werknemer
    {
        [Key]
        public int werknemer_id { get; set; }
        [Display(Name ="First name")]
        public string firstName { get; set; }
        [Display(Name ="Last name")]
        public string lastName { get; set; }
        [Display(Name ="Email")]
        public string email { get; set; }
        [Display(Name = "Verlof")]
        public string verlof { get; set; }
    }
}
