using CrystalDecisions.CrystalReports.Engine;
using NiceHmsApp.Database;
using NiceHmsApp.Models;
using NiceHmsApp.Models.ViewModels;
using NiceHmsApp.ViewModels;
using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Web.Mvc;

namespace NiceHmsApp.Areas.Marketing.Controllers
{

    public class MarketingController : Controller
    {
        private DatabaseContext db = new DatabaseContext();
        // GET: Marketing/Marketing
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(MarketingViewModel obj)
        {
            string title = obj.param_type;
            try
            {
                MarketingCompany c = new MarketingCompany();
                c.company_full_name = obj.company_full_name;
                c.company_name = obj.company_name;
                c.permanent_address_1 = obj.permanent_address_1;
                c.permanent_address_2 = obj.permanent_address_2;
                c.permanent_post_code = obj.permanent_post_code;
                c.permanent_country = obj.permanent_country;
                c.permanent_city = obj.permanent_city;
                c.present_address_1 = obj.present_address_1;
                c.present_address_2 = obj.present_address_2;
                c.present_post_code = obj.present_post_code;
                c.present_country = obj.present_country;
                c.present_city = obj.present_city;
                c.mobile = obj.mobile;
                c.phone = obj.phone;
                c.email = obj.email;
                c.web = obj.web;
                c.fax = obj.fax;
                c.type = obj.type;
                c.status = obj.status;
                c.create_date = obj.create_date;
                db.MarketingCompanies.Add(c);
                db.SaveChanges();

                MarketingContactPerson p = new MarketingContactPerson();
                p.marketing_com_id = c.id;
                p.name = obj.name;
                p.designation = obj.designation;
                p.mobile = obj.pmobile;
                p.phone = obj.pphone;
                p.email = obj.pemail;
                p.status = obj.pstatus;
                p.dob = obj.dob;
                p.create_date = obj.pcreate_date;
                db.MarketingContactPeople.Add(p);
                db.SaveChanges();

                MarketingOffer o = new MarketingOffer();
                o.marketing_com_id = c.id;
                o.benquet_discount = obj.benquet_discount;
                o.room_discount = obj.room_discount;
                o.restaurent_discount = obj.restaurent_discount;
                o.offer_type = obj.offer_type;
                o.service_charge = obj.service_charge;
                o.vat = obj.vat;
                o.status = obj.ostatus;
                o.create_date = obj.ocreate_date;
                db.MarketingOffers.Add(o);
                db.SaveChanges();

                ViewBag.SuccessMessage = "Record save successfuly.";
                return View();
            }
            catch (Exception e)
            {
                ViewBag.ErrorMessage = e.Message.ToString();
                return View();
            }
        }

        public ActionResult List()
        {
            return View(db.MarketingCompanies.ToList());
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarketingCompany marketingCompany = db.MarketingCompanies.Find(id);
            if (marketingCompany == null)
            {
                return HttpNotFound();
            }
            return View(marketingCompany);
        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            MarketingCompany marketingCompany = db.MarketingCompanies.Find(id);
            if (marketingCompany == null)
            {
                return HttpNotFound();
            }
            return View(marketingCompany);
        }

        public ActionResult ContactPeopleList()
        {
            return View(db.MarketingContactPeople.ToList());
        }

        public ActionResult OffersList()
        {
            return View(db.MarketingOffers.ToList());
        }

        public ActionResult ContactPeopleReport()
        {
            ReportDocument crd = new ReportDocument();
            crd.Load(Path.Combine(Server.MapPath("~/Report/ContactPeopleReport.rpt")));
            crd.SetDataSource(db.MarketingContactPeople.ToList());
            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();
            try
            {
                Stream stream = crd.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
                stream.Seek(0, SeekOrigin.Begin);
                String savedFilename = string.Format("list", DateTime.Now);
                return File(stream, "application/pdf", savedFilename);
            }
            catch
            {
                throw;
            }
        }

        public ActionResult OffersReport()
        {
            ReportDocument ord = new ReportDocument();
            ord.Load(Path.Combine(Server.MapPath("~/Report"), "OffersReport.rpt"));
            ord.SetDataSource(db.MarketingOffers.ToList());
            Response.Buffer = false;
            Response.ClearContent();
            Response.ClearHeaders();
            Stream stream = ord.ExportToStream(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat);
            stream.Seek(0, SeekOrigin.Begin);
            return File(stream, "application/pdf", "OffersReport.pdf");
           
        }

    }
}