using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHmsApp.Models
{
    [Table("hms_users")]
    public class UserModel
    {
        public int id { get; set; }

        [Required]
        [StringLength(80)]
        [Display(Name = "Full Name")]
        public string full_name { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "User Name")]
        public string user_name { get; set; }

        [Required]
        [StringLength(80)]
        [Display(Name = "Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string email { get; set; }

        [Required]
        [StringLength(50)]
        [Display(Name = "Password")]
        public string password { get; set; }

        [Required]
        [StringLength(80)]
        [Display(Name = "Designation")]
        public string designation { get; set; }

        [Display(Name = "Is Active?")]
        public short status { get; set; }

        public int create_by { get; set; }

        public DateTime create_date { get; set; }

        public int? update_by { get; set; }

        public DateTime? update_date { get; set; }
    }
}
