using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NiceHmsApp.Models.ViewModels
{
    public class MarketingListVM
    {
        public List<MarketingCompany> MarketingCompanies { get; set; }
        public List<MarketingContactPerson>  MarketingContacts { get; set; }
        public List<MarketingOffer> MarketingOffers { get; set; } 

    }
}
