using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHmsApp.Models
{
    [Table("hms_payment")]
    public class PaymentModel
    {
        public int id { get; set; }

        public int? service_id { get; set; }

        public int? restaurent_id { get; set; }

        public int? laundry_id { get; set; }

        public int? bar_id { get; set; }

        public int? banquet_id { get; set; }

        public int? payment_amount_cr { get; set; }

        public int? payment_amount_dr { get; set; }

        [StringLength(50)]
        public string payment_type { get; set; }

        public int payment_method_id { get; set; }

        [StringLength(50)]
        public string payment_description { get; set; }

        public DateTime? payment_date { get; set; }

        [StringLength(50)]
        public string service_code { get; set; }

        public int? isClose { get; set; }

        [StringLength(100)]
        public string remarks { get; set; }

        public int? status { get; set; }

        public int create_by { get; set; }

        public DateTime create_date { get; set; }

        public int? update_by { get; set; }

        public DateTime? update_date { get; set; }
    }
}
