﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace company_system
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    
    public partial class Trading_CompanyEntities6 : DbContext
    {
        public Trading_CompanyEntities6()
            : base("name=Trading_CompanyEntities6")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<client> clients { get; set; }
        public virtual DbSet<issuance_request> issuance_request { get; set; }
        public virtual DbSet<Item> Items { get; set; }
        public virtual DbSet<supplier> suppliers { get; set; }
        public virtual DbSet<supply_request> supply_request { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<warehouse> warehouses { get; set; }
        public virtual DbSet<warehouse_trasactions> warehouse_trasactions { get; set; }


        
    }
}
