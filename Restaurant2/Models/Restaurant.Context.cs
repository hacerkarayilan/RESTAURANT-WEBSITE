﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant1.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class RestaurantEntities10 : DbContext
    {
        public RestaurantEntities10()
            : base("name=RestaurantEntities10")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Addresses> Addresses { get; set; }
        public virtual DbSet<Admin> Admin { get; set; }
        public virtual DbSet<AdminOrder> AdminOrder { get; set; }
        public virtual DbSet<Food> Food { get; set; }
        public virtual DbSet<Inventory> Inventory { get; set; }
        public virtual DbSet<Kurye> Kurye { get; set; }
        public virtual DbSet<orders> orders { get; set; }
        public virtual DbSet<Recipe> Recipe { get; set; }
        public virtual DbSet<users> users { get; set; }
        public virtual DbSet<Kupon> Kupon { get; set; }
    }
}
