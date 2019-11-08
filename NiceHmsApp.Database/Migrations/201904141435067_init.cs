namespace NiceHmsApp.Database.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MarketingCompanies",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        company_full_name = c.String(nullable: false),
                        company_name = c.String(nullable: false),
                        permanent_address_1 = c.String(nullable: false),
                        permanent_address_2 = c.String(),
                        permanent_post_code = c.String(nullable: false),
                        permanent_country = c.String(nullable: false),
                        permanent_city = c.String(),
                        present_address_1 = c.String(),
                        present_address_2 = c.String(),
                        present_post_code = c.String(),
                        present_country = c.String(),
                        present_city = c.String(),
                        mobile = c.String(maxLength: 14),
                        phone = c.String(),
                        email = c.String(nullable: false),
                        web = c.String(),
                        fax = c.String(),
                        type = c.String(nullable: false),
                        status = c.Int(nullable: false),
                        create_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.MarketingContactPersons",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        name = c.String(nullable: false),
                        designation = c.String(nullable: false),
                        mobile = c.String(maxLength: 14),
                        phone = c.String(),
                        email = c.String(nullable: false),
                        status = c.Int(nullable: false),
                        dob = c.DateTime(nullable: false),
                        create_date = c.DateTime(nullable: false),
                        marketing_com_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.MarketingCompanies", t => t.marketing_com_id, cascadeDelete: true)
                .Index(t => t.marketing_com_id);
            
            CreateTable(
                "dbo.MarketingOffers",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        benquet_discount = c.String(nullable: false),
                        room_discount = c.String(nullable: false),
                        restaurent_discount = c.String(nullable: false),
                        offer_type = c.String(nullable: false),
                        service_charge = c.Int(nullable: false),
                        vat = c.Int(nullable: false),
                        status = c.Int(nullable: false),
                        create_date = c.DateTime(nullable: false),
                        marketing_com_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id)
                .ForeignKey("dbo.MarketingCompanies", t => t.marketing_com_id, cascadeDelete: true)
                .Index(t => t.marketing_com_id);
            
            CreateTable(
                "dbo.MarketingViewModels",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        company_full_name = c.String(),
                        company_name = c.String(),
                        permanent_address_1 = c.String(),
                        permanent_address_2 = c.String(),
                        permanent_post_code = c.String(),
                        permanent_country = c.String(),
                        permanent_city = c.String(),
                        present_address_1 = c.String(),
                        present_address_2 = c.String(),
                        present_post_code = c.String(),
                        present_country = c.String(),
                        present_city = c.String(),
                        mobile = c.String(),
                        phone = c.String(),
                        email = c.String(),
                        web = c.String(),
                        fax = c.String(),
                        type = c.String(),
                        status = c.Int(nullable: false),
                        create_date = c.DateTime(nullable: false),
                        name = c.String(),
                        designation = c.String(),
                        pmobile = c.String(),
                        pphone = c.String(),
                        pemail = c.String(),
                        pstatus = c.Int(nullable: false),
                        dob = c.DateTime(nullable: false),
                        pcreate_date = c.DateTime(nullable: false),
                        marketing_com_id = c.Int(nullable: false),
                        benquet_discount = c.String(),
                        room_discount = c.String(),
                        restaurent_discount = c.String(),
                        offer_type = c.String(),
                        service_charge = c.Int(nullable: false),
                        vat = c.Int(nullable: false),
                        ostatus = c.Int(nullable: false),
                        ocreate_date = c.DateTime(nullable: false),
                        omarketing_com_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.hms_paymentMethod",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        method_name = c.String(nullable: false, maxLength: 50),
                        method_type = c.String(nullable: false, maxLength: 50),
                        ledger_type = c.String(nullable: false, maxLength: 50),
                        method_description = c.String(nullable: false, maxLength: 50),
                        method_commission = c.Int(nullable: false),
                        status = c.Int(),
                        create_by = c.Int(nullable: false),
                        create_date = c.DateTime(nullable: false),
                        update_by = c.Int(),
                        update_date = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.hms_payment",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        service_id = c.Int(),
                        restaurent_id = c.Int(),
                        laundry_id = c.Int(),
                        bar_id = c.Int(),
                        banquet_id = c.Int(),
                        payment_amount_cr = c.Int(),
                        payment_amount_dr = c.Int(),
                        payment_type = c.String(maxLength: 50),
                        payment_method_id = c.Int(nullable: false),
                        payment_description = c.String(maxLength: 50),
                        payment_date = c.DateTime(),
                        service_code = c.String(maxLength: 50),
                        isClose = c.Int(),
                        remarks = c.String(maxLength: 100),
                        status = c.Int(),
                        create_by = c.Int(nullable: false),
                        create_date = c.DateTime(nullable: false),
                        update_by = c.Int(),
                        update_date = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.hms_reserved",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        first_name = c.String(nullable: false, maxLength: 100),
                        middle_name = c.String(nullable: false, maxLength: 100),
                        last_name = c.String(nullable: false, maxLength: 100),
                        mobile_no = c.String(nullable: false, maxLength: 100),
                        email = c.String(nullable: false, maxLength: 100),
                        city = c.String(nullable: false, maxLength: 100),
                        country = c.Int(nullable: false),
                        address = c.String(nullable: false, maxLength: 100),
                        zip = c.String(nullable: false, maxLength: 100),
                        stare = c.String(nullable: false, maxLength: 100),
                        passportnid = c.String(name: "passport/nid", nullable: false, maxLength: 100),
                        dob = c.DateTime(nullable: false),
                        gender = c.Int(nullable: false),
                        exp_arrival_date = c.DateTime(nullable: false),
                        exp_deputure_date = c.DateTime(nullable: false),
                        reservation_no = c.Int(nullable: false),
                        registration_no = c.Int(),
                        room_type = c.Int(),
                        room_no = c.Int(),
                        room_rate = c.Int(),
                        extra_bad_rate = c.Int(),
                        service_charge = c.Int(),
                        vat = c.Int(),
                        audult = c.Int(),
                        children = c.Int(),
                        payment_id = c.Int(),
                        company_id = c.Int(),
                        remarks = c.Int(),
                        status = c.Int(),
                        create_by = c.Int(nullable: false),
                        create_date = c.DateTime(nullable: false),
                        update_by = c.Int(),
                        update_date = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.hms_roles",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        role = c.String(nullable: false, maxLength: 50),
                        description = c.String(nullable: false, maxLength: 80),
                        create_by = c.Int(nullable: false),
                        create_date = c.DateTime(nullable: false),
                        update_by = c.Int(),
                        update_date = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.hms_roomList",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        room_no = c.Int(),
                        room_type_id = c.Int(),
                        fo_status = c.Short(),
                        fnb_status = c.Short(),
                        hk_status = c.Short(),
                        remarks = c.String(maxLength: 100),
                        create_by = c.Int(nullable: false),
                        create_date = c.DateTime(nullable: false),
                        update_by = c.Int(),
                        update_date = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.hms_roomType",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        room_type_name = c.String(nullable: false, maxLength: 100),
                        room_rack_rate_usd_1 = c.Int(nullable: false),
                        room_rack_rate_usd_2 = c.Int(nullable: false),
                        room_rack_rate_usd_3 = c.Int(nullable: false),
                        room_rack_rate_bdt_1 = c.Int(nullable: false),
                        room_rack_rate_bdt_2 = c.Int(nullable: false),
                        room_rack_rate_bdt_3 = c.Int(nullable: false),
                        extra_bad_amount = c.Int(nullable: false),
                        create_by = c.Int(nullable: false),
                        create_date = c.DateTime(nullable: false),
                        update_by = c.Int(),
                        update_date = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.hms_userLog",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        user_id = c.Int(nullable: false),
                        module_name = c.Binary(nullable: false, maxLength: 100),
                        description = c.Binary(nullable: false, maxLength: 150),
                        create_date = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.hms_users",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        full_name = c.String(nullable: false, maxLength: 80),
                        user_name = c.String(nullable: false, maxLength: 50),
                        email = c.String(nullable: false, maxLength: 80),
                        password = c.String(nullable: false, maxLength: 50),
                        designation = c.String(nullable: false, maxLength: 80),
                        status = c.Short(nullable: false),
                        create_by = c.Int(nullable: false),
                        create_date = c.DateTime(nullable: false),
                        update_by = c.Int(),
                        update_date = c.DateTime(),
                    })
                .PrimaryKey(t => t.id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MarketingOffers", "marketing_com_id", "dbo.MarketingCompanies");
            DropForeignKey("dbo.MarketingContactPersons", "marketing_com_id", "dbo.MarketingCompanies");
            DropIndex("dbo.MarketingOffers", new[] { "marketing_com_id" });
            DropIndex("dbo.MarketingContactPersons", new[] { "marketing_com_id" });
            DropTable("dbo.hms_users");
            DropTable("dbo.hms_userLog");
            DropTable("dbo.hms_roomType");
            DropTable("dbo.hms_roomList");
            DropTable("dbo.hms_roles");
            DropTable("dbo.hms_reserved");
            DropTable("dbo.hms_payment");
            DropTable("dbo.hms_paymentMethod");
            DropTable("dbo.MarketingViewModels");
            DropTable("dbo.MarketingOffers");
            DropTable("dbo.MarketingContactPersons");
            DropTable("dbo.MarketingCompanies");
        }
    }
}
