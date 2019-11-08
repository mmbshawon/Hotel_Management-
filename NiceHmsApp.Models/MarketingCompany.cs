using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHmsApp.Models
{
   // [Table("tbl_marketing_company")]
    
    public class MarketingCompany
    {
        public int id { get; set; }
        [Required]
        public string company_full_name { get; set; }
        [Required]
        public string company_name { get; set; }
        [Required]
        public string permanent_address_1 { get; set; }
        public string permanent_address_2 { get; set; }
        [Required]
        public string permanent_post_code { get; set; }
        [Required]
        public string permanent_country { get; set; }
        public string permanent_city { get; set; }
        public string present_address_1 { get; set; }
        public string present_address_2 { get; set; }
        public string present_post_code { get; set; }
        public string present_country { get; set; }
        public string present_city { get; set; }
        [MaxLength(14), MinLength(11, ErrorMessage = "Valid Number")]
        public string mobile { get; set; }
        public string phone { get; set; }
        [Required]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                        @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                        @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                        ErrorMessage = "Email is not valid")]
        public string email { get; set; }
        public string web { get; set; }
        public string fax { get; set; }
        [Required]
        public string type { get; set; }
        public int status { get; set; }
        [Required(ErrorMessage = "Date is Required (dd/mm/yyyy)")]
        [DataType(DataType.DateTime)]
        public DateTime create_date { get; set; }
        [NotMapped]
        public virtual List<MarketingContactPerson> MarketingContactPeople { get; set; }
        [NotMapped]
        public virtual List<MarketingOffer> MarketingOffers { get; set; }
    }
}
