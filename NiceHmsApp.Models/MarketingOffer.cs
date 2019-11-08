using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHmsApp.Models
{
  //  [Table("tbl_marketing_offer")]
    public class MarketingOffer
    {
        public int id { get; set; }
        [Required]
        public string benquet_discount { get; set; }
        [Required]
        public string room_discount { get; set; }
        [Required]
        public string restaurent_discount { get; set; }
        [Required]
        public string offer_type { get; set; }
        public int service_charge { get; set; }
        public int vat { get; set; }
        public int status { get; set; }
        [Required(ErrorMessage = "Date is Required (dd/mm/yyyy)")]
        [DataType(DataType.DateTime)] 
        public DateTime create_date { get; set; }
        [ForeignKey("MarketingCompany")]
        public int marketing_com_id { get; set; }
        public virtual MarketingCompany MarketingCompany { get; set; }
    }
}
