﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Shopping_DBEntities5 : DbContext
    {
        public Shopping_DBEntities5()
            : base("name=Shopping_DBEntities5")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<addToCart> addToCarts { get; set; }
        public virtual DbSet<Bill_To> Bill_To { get; set; }
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<contact_us> contact_us { get; set; }
        public virtual DbSet<MappingsTable> MappingsTables { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<Shopper_Information> Shopper_Information { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Users11> Users11 { get; set; }
        public virtual DbSet<UsersTable> UsersTables { get; set; }
    }
}