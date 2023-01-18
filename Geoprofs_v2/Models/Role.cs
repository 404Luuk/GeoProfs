using System.ComponentModel.DataAnnotations;

namespace Geoprofs_v2.Models
{
    public class Role
    {
        [Key]
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }
}
