namespace NiceHmsApp.Database
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using NiceHmsApp.Models;

    public partial class DatabaseContext : DbContext
    {
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }
        public DbSet<MarketingCompany> MarketingCompanies { get; set; }
        public DbSet<MarketingContactPerson> MarketingContactPeople { get; set; }
        public DbSet<MarketingOffer> MarketingOffers { get; set; }

        public virtual DbSet<PaymentModel> PaymentModel { get; set; }
        public virtual DbSet<PaymentMethodModel> PaymentMethodModel { get; set; }
        public virtual DbSet<ReservedModel> ReservedModel { get; set; }
        public virtual DbSet<RoleModel> RoleModel { get; set; }
        public virtual DbSet<RoomListModel> RoomListModel { get; set; }
        public virtual DbSet<RoomTypeModel> RoomTypeModel { get; set; }
        public virtual DbSet<UserLogModel> UserLogModel { get; set; }
        public virtual DbSet<UserModel> UserModel { get; set; }

        public System.Data.Entity.DbSet<NiceHmsApp.ViewModels.MarketingViewModel> MarketingViewModels { get; set; }

        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<hms_payment>()
        //        .Property(e => e.payment_type)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_payment>()
        //        .Property(e => e.payment_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_payment>()
        //        .Property(e => e.service_code)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_payment>()
        //        .Property(e => e.remarks)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_paymentMethod>()
        //        .Property(e => e.method_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_paymentMethod>()
        //        .Property(e => e.method_type)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_paymentMethod>()
        //        .Property(e => e.ledger_type)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_paymentMethod>()
        //        .Property(e => e.method_description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_reserved>()
        //        .Property(e => e.first_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_reserved>()
        //        .Property(e => e.middle_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_reserved>()
        //        .Property(e => e.last_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_reserved>()
        //        .Property(e => e.mobile_no)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_reserved>()
        //        .Property(e => e.email)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_reserved>()
        //        .Property(e => e.city)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_reserved>()
        //        .Property(e => e.address)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_reserved>()
        //        .Property(e => e.zip)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_reserved>()
        //        .Property(e => e.stare)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_reserved>()
        //        .Property(e => e.passport_nid)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_roles>()
        //        .Property(e => e.role)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_roles>()
        //        .Property(e => e.description)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_roomList>()
        //        .Property(e => e.remarks)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_roomType>()
        //        .Property(e => e.room_type_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_users>()
        //        .Property(e => e.full_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_users>()
        //        .Property(e => e.user_name)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_users>()
        //        .Property(e => e.email)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_users>()
        //        .Property(e => e.password)
        //        .IsUnicode(false);

        //    modelBuilder.Entity<hms_users>()
        //        .Property(e => e.designation)
        //        .IsUnicode(false);
        //}
    }
}
