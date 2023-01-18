using Microsoft.VisualBasic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Geoprofs_v2.Models
{
    public enum reden 
    {
        sick,
        personal,
        vacation,
        other
    }

    public class VerlofReden
    {
        [Key]
        public int id { get; set; }

        public reden verlofReden { get; set; }
    }
}
