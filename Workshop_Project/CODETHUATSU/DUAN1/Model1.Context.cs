﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DUAN1
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class DAXuongEntities : DbContext
    {
        public DAXuongEntities()
            : base("name=DAXuongEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<chi_tiet_hoa_don> chi_tiet_hoa_don { get; set; }
        public virtual DbSet<chitiet_hanghoa> chitiet_hanghoa { get; set; }
        public virtual DbSet<dang_nhap> dang_nhap { get; set; }
        public virtual DbSet<hang_hoa> hang_hoa { get; set; }
        public virtual DbSet<hoa_don> hoa_don { get; set; }
        public virtual DbSet<khach_hang> khach_hang { get; set; }
        public virtual DbSet<nhan_vien> nhan_vien { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}