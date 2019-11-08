using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHmsApp.Models
{
    [Table("hms_roomList")]
   public class RoomListModel
   {
        public int id { get; set; }

        [Display(Name = "Room No.")]
        public int? room_no { get; set; }

        [Display(Name = "Room Type")]
        public int? room_type_id { get; set; }

        public short? fo_status { get; set; }

        public short? fnb_status { get; set; }

        public short? hk_status { get; set; }

        [StringLength(100)]
        public string remarks { get; set; }

        public int create_by { get; set; }

        public DateTime create_date { get; set; }

        public int? update_by { get; set; }

        public DateTime? update_date { get; set; }
    }
}
