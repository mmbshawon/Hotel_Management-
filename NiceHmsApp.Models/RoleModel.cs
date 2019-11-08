using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHmsApp.Models
{
    [Table("hms_roles")]
    public class RoleModel
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Role")]
        public string role { get; set; }

        [Required]
        [StringLength(80)]
        [Display(Name = "Description")]
        public string description { get; set; }

        public int create_by { get; set; }

        public DateTime create_date { get; set; }

        public int? update_by { get; set; }

        public DateTime? update_date { get; set; }
    }
}
