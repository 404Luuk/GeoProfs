using System.ComponentModel.DataAnnotations;

namespace Geoprofs_v2.Models
{
    public class Department
    {
        [Key]
        public int id { get; set; }
        [Display(Name = "Department name")]
        public string name { get; set; }
        public string description { get; set; }
    }
}
