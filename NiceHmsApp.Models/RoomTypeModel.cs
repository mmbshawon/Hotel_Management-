using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHmsApp.Models
{
    [Table("hms_roomType")]
    public class RoomTypeModel
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Room Type Name")]
        public string room_type_name { get; set; }

        public int room_rack_rate_usd_1 { get; set; }

        public int room_rack_rate_usd_2 { get; set; }

        public int room_rack_rate_usd_3 { get; set; }

        public int room_rack_rate_bdt_1 { get; set; }

        public int room_rack_rate_bdt_2 { get; set; }

        public int room_rack_rate_bdt_3 { get; set; }

        public int extra_bad_amount { get; set; }

        public int create_by { get; set; }

        public DateTime create_date { get; set; }

        public int? update_by { get; set; }

        public DateTime? update_date { get; set; }
    }
}
