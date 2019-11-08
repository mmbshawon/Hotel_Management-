using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHmsApp.Models
{
    [Table("hms_reserved")]
    public class ReservedModel
    {
        public int id { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "First Name")]
        public string first_name { get; set; }

        [Required]
        [StringLength(100)]
        public string middle_name { get; set; }

        [Required]
        [StringLength(100)]
        public string last_name { get; set; }

        [Required]
        [StringLength(100)]
        public string mobile_no { get; set; }

        [Required]
        [StringLength(100)]
        [Display(Name = "Email")]
        [RegularExpression(@"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*")]
        public string email { get; set; }

        [Required]
        [StringLength(100)]
        public string city { get; set; }

        public int country { get; set; }

        [Required]
        [StringLength(100)]
        public string address { get; set; }

        [Required]
        [StringLength(100)]
        public string zip { get; set; }

        [Required]
        [StringLength(100)]
        public string stare { get; set; }

        [Column("passport/nid")]
        [Required]
        [StringLength(100)]
        public string passport_nid { get; set; }

        public DateTime dob { get; set; }

        public int gender { get; set; }

        public DateTime exp_arrival_date { get; set; }

        public DateTime exp_deputure_date { get; set; }

        public int reservation_no { get; set; }

        public int? registration_no { get; set; }

        public int? room_type { get; set; }

        public int? room_no { get; set; }

        public int? room_rate { get; set; }

        public int? extra_bad_rate { get; set; }

        public int? service_charge { get; set; }

        public int? vat { get; set; }

        public int? audult { get; set; }

        public int? children { get; set; }

        public int? payment_id { get; set; }

        public int? company_id { get; set; }

        public int? remarks { get; set; }

        public int? status { get; set; }

        public int create_by { get; set; }

        public DateTime create_date { get; set; }

        public int? update_by { get; set; }

        public DateTime? update_date { get; set; }
    }
}
