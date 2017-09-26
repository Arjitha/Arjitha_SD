using Arjitha.Models;
using Microsoft.EntityFrameworkCore;
//using Arjitha.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Arjitha.Data
{
    public class ArjithaContext : DbContext
    {
        public ArjithaContext(DbContextOptions<ArjithaContext> options) : base(options)
        {
        }

        public DbSet<ArjithaEmployees> ArjithaEmpCntx { get; set; }
        public DbSet<FlatDetails> FDetailsCntx { get; set; }
        public DbSet<FlatOwnerDetails> FOwnerDetailsCntx { get; set; }
        public DbSet<ResidentDetails> RDetailsCntx { get; set; }
        public DbSet<ResidentRechargeHistory> RHistoryCntx { get; set; }
        public DbSet<ServiceRequest> SRequestCntx { get; set; }
        public DbSet<ServiceRequestChild> SRequestChildCntx { get; set; }
        public DbSet<ServiceRequestQuotation> SRQuotationCntx { get; set; }
        public DbSet<VendorDetails> VDetailsCntx { get; set; }
        public DbSet<Vendors_HandyMan_Details> VHandyManDetailsCntx { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ArjithaEmployees>().ToTable("ArjithaEmployees");
            modelBuilder.Entity<FlatDetails>().ToTable("FlatDetails");
            modelBuilder.Entity<FlatOwnerDetails>().ToTable("FlatOwnerDetails");
            modelBuilder.Entity<ResidentDetails>().ToTable("ResidentDetails");
            modelBuilder.Entity<ResidentRechargeHistory>().ToTable("ResidentRechargeHistory");
            modelBuilder.Entity<ServiceRequest>().ToTable("ServiceRequest");
            modelBuilder.Entity<ServiceRequestChild>().ToTable("ServiceRequestChild");
            modelBuilder.Entity<ServiceRequestQuotation>().ToTable("ServiceRequestQuotation");
            modelBuilder.Entity<VendorDetails>().ToTable("VendorDetails");
            modelBuilder.Entity<Vendors_HandyMan_Details>().ToTable("Vendors_HandyMan_Details");
        }

        //public DbSet<PropCroc.Models.PPESignUp> PPESignUp { get; set; }
    }
}
