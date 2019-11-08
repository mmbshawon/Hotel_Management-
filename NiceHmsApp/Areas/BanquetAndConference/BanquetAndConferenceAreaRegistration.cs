using System.Web.Mvc;

namespace NiceHmsApp.Areas.BanquetAndConference
{
    public class BanquetAndConferenceAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "BanquetAndConference";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "BanquetAndConference_default",
                "BanquetAndConference/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}