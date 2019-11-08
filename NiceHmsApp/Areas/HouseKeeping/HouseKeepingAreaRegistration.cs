using System.Web.Mvc;

namespace NiceHmsApp.Areas.HouseKeeping
{
    public class HouseKeepingAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "HouseKeeping";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "HouseKeeping_default",
                "HouseKeeping/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}