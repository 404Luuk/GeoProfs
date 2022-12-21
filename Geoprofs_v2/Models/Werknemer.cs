using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Geoprofs_v2.Models
{
    public class Werknemer
    {
        [Key]
        public int id { get; set; }
        [Display(Name ="First name")]
        public string firstName { get; set; }
        [Display(Name ="Last name")]
        public string lastName { get; set; }
        [Display(Name ="Email")]
        public string email { get; set; }

        // Department foreign key
        [ForeignKey("Department")]
        public int departmentId { get; set; }
        public virtual Department Department { get; set; }

        // Role foreign key
        [ForeignKey("Role")]
        public int roleId { get; set; }
        public virtual Role Role { get; set; } 
    }
}
