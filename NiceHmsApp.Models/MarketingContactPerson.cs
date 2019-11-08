using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHmsApp.Models
{
   // [Table("tbl_marketing_contact_person")]
    public class MarketingContactPerson
    {
        public int id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string designation { get; set; }
        [MaxLength(14), MinLength(11, ErrorMessage = "Valid Number")]
        public string mobile { get; set; }
        public string phone { get; set; }
        [Required]
        [RegularExpression(@"^([a-zA-Z0-9_\-\.]+)@((\[[0-9]{1,3}" +
                        @"\.[0-9]{1,3}\.[0-9]{1,3}\.)|(([a-zA-Z0-9\-]+\" +
                        @".)+))([a-zA-Z]{2,4}|[0-9]{1,3})(\]?)$",
                        ErrorMessage = "Email is not valid")]
        public string email { get; set; }
        public int status { get; set; }
        [Required(ErrorMessage = "Date is Required (dd/mm/yyyy)")]
        [DataType(DataType.DateTime)]
        public DateTime dob { get; set; }
        [Required(ErrorMessage = "Date is Required (dd/mm/yyyy)")]
        [DataType(DataType.DateTime)]
        public DateTime create_date { get; set; }
        [ForeignKey("MarketingCompany")]
        public int marketing_com_id { get; set; }
        public virtual MarketingCompany MarketingCompany { get; set; }
    }
}
