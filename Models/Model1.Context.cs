﻿//------------------------------------------------------------------------------
// <auto-generated>
//    Этот код был создан из шаблона.
//
//    Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//    Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WpfRent.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class WpfRenttEntities : DbContext
    {
        public WpfRenttEntities()
            : base("name=WpfRenttEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Announcement> Announcement { get; set; }
        public DbSet<Characteristics> Characteristics { get; set; }
        public DbSet<Location> Location { get; set; }
        public DbSet<Realtor> Realtor { get; set; }
        public DbSet<Responses> Responses { get; set; }
        public DbSet<sysdiagrams> sysdiagrams { get; set; }
        public DbSet<Users> Users { get; set; }
    }
}