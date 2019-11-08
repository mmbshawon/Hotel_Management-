using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHmsApp.Models
{
    [Table("hms_paymentMethod")]
    public class PaymentMethodModel
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string method_name { get; set; }

        [Required]
        [StringLength(50)]
        public string method_type { get; set; }

        [Required]
        [StringLength(50)]
        public string ledger_type { get; set; }

        [Required]
        [StringLength(50)]
        public string method_description { get; set; }

        public int method_commission { get; set; }

        public int? status { get; set; }

        public int create_by { get; set; }

        public DateTime create_date { get; set; }

        public int? update_by { get; set; }

        public DateTime? update_date { get; set; }
    }
}
