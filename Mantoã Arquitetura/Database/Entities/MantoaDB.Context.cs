﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Mantoã_Arquitetura.Database.Entities
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class mantoadbEntities : DbContext
    {
        public mantoadbEntities()
            : base("name=mantoadbEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<tb_account> tb_account { get; set; }
        public virtual DbSet<tb_bankaccount> tb_bankaccount { get; set; }
        public virtual DbSet<tb_benefits> tb_benefits { get; set; }
        public virtual DbSet<tb_client> tb_client { get; set; }
        public virtual DbSet<tb_cpp> tb_cpp { get; set; }
        public virtual DbSet<tb_department> tb_department { get; set; }
        public virtual DbSet<tb_discounts> tb_discounts { get; set; }
        public virtual DbSet<tb_employees> tb_employees { get; set; }
        public virtual DbSet<tb_enterprise> tb_enterprise { get; set; }
        public virtual DbSet<tb_financial> tb_financial { get; set; }
        public virtual DbSet<tb_function> tb_function { get; set; }
        public virtual DbSet<tb_iten> tb_iten { get; set; }
        public virtual DbSet<tb_points> tb_points { get; set; }
        public virtual DbSet<tb_product> tb_product { get; set; }
        public virtual DbSet<tb_provider> tb_provider { get; set; }
        public virtual DbSet<tb_sale> tb_sale { get; set; }
        public virtual DbSet<tb_supply> tb_supply { get; set; }
        public virtual DbSet<tb_timecard> tb_timecard { get; set; }
        public virtual DbSet<tb_cnae> tb_cnae { get; set; }
        public virtual DbSet<tb_crm> tb_crm { get; set; }
    }
}
