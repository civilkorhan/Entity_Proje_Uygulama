﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Entity_Proje_Uygulama
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class DB_Entity_UrunEntities : DbContext
    {
        public DB_Entity_UrunEntities()
            : base("name=DB_Entity_UrunEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<TBL_KATEGORILER> TBL_KATEGORILER { get; set; }
        public virtual DbSet<TBL_MUSTERILER> TBL_MUSTERILER { get; set; }
        public virtual DbSet<TBL_SATIS> TBL_SATIS { get; set; }
        public virtual DbSet<TBL_URUNLER> TBL_URUNLER { get; set; }
        public virtual DbSet<TBL_ADMIN> TBL_ADMIN { get; set; }
    
        public virtual ObjectResult<string> MARKA_GETIR()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<string>("MARKA_GETIR");
        }
    }
}
