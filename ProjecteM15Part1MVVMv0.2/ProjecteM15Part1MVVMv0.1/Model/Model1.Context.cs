﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProjecteM15Part1MVVMv0._1.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class repartosEntities : DbContext
    {
        public repartosEntities()
            : base("name=repartosEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<administrador> administrador { get; set; }
        public DbSet<cliente> cliente { get; set; }
        public DbSet<factura> factura { get; set; }
        public DbSet<pedido> pedido { get; set; }
        public DbSet<repartidor> repartidor { get; set; }
    }
}