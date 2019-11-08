using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHmsApp.Models
{
    [Table("hms_userLog")]
    public class UserLogModel
    {
        public int id { get; set; }

        public int user_id { get; set; }

        [Required]
        [MaxLength(100)]
        public byte[] module_name { get; set; }

        [Required]
        [MaxLength(150)]
        public byte[] description { get; set; }

        public DateTime create_date { get; set; }
    }
}
