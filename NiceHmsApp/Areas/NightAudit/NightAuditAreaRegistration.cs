using System.Web.Mvc;

namespace NiceHmsApp.Areas.NightAudit
{
    public class NightAuditAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "NightAudit";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "NightAudit_default",
                "NightAudit/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}