﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SportCenter.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class sportcenterEntities4 : DbContext
    {
        public sportcenterEntities4()
            : base("name=sportcenterEntities4")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<account> accounts { get; set; }
        public virtual DbSet<bill> bills { get; set; }
        public virtual DbSet<bookingInfo> bookingInfoes { get; set; }
        public virtual DbSet<buyingInfo> buyingInfoes { get; set; }
        public virtual DbSet<employee> employees { get; set; }
        public virtual DbSet<field> fields { get; set; }
        public virtual DbSet<fieldtype> fieldtypes { get; set; }
        public virtual DbSet<good> goods { get; set; }
        public virtual DbSet<MSreplication_options> MSreplication_options { get; set; }
        public virtual DbSet<spt_fallback_db> spt_fallback_db { get; set; }
        public virtual DbSet<spt_fallback_dev> spt_fallback_dev { get; set; }
        public virtual DbSet<spt_fallback_usg> spt_fallback_usg { get; set; }
        public virtual DbSet<spt_monitor> spt_monitor { get; set; }
    }
}
