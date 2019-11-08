using NiceHmsApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace NiceHmsApp.ViewModels
{
    public class MarketingViewModel
    {
        //param
        public string param_type { get; set;}

        //marketing company
        public string company_full_name { get; set; }
        public string company_name { get; set; }
        public string permanent_address_1 { get; set; }
        public string permanent_address_2 { get; set; }
        public string permanent_post_code { get; set; }
        public string permanent_country { get; set; }
        public string permanent_city { get; set; }
        public string present_address_1 { get; set; }
        public string present_address_2 { get; set; }
        public string present_post_code { get; set; }
        public string present_country { get; set; }
        public string present_city { get; set; }
        public string mobile { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string web { get; set; }
        public string fax { get; set; }
        public string type { get; set; }
        public int status { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime create_date { get; set; }

        //marketing cntact person
        public string name { get; set; }
        public string designation { get; set; }
        public string pmobile { get; set; }
        public string pphone { get; set; }
        public string pemail { get; set; }
        public int pstatus { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime dob { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime pcreate_date { get; set; }
        public int marketing_com_id { get; set; }


        //marketing offer
        public int id { get; set; }
        public string benquet_discount { get; set; }
        public string room_discount { get; set; }
        public string restaurent_discount { get; set; }
        public string offer_type { get; set; }
        public int service_charge { get; set; }
        public int vat { get; set; }
        public int ostatus { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime ocreate_date { get; set; } 
        public int omarketing_com_id { get; set; }
        

    } 
}