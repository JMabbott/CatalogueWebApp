﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Catalogue.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class CatalogueDBEntities : DbContext
    {
        public CatalogueDBEntities()
            : base("name=CatalogueDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Catalogue> Catalogues { get; set; }
        public DbSet<CatalogueItem> CatalogueItems { get; set; }
        public DbSet<Stat> Stats { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<SubCatalogue> SubCatalogues { get; set; }
    }
}
