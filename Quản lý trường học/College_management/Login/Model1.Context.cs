﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Login
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class COLLEGE_MANAGEMENTEntities1 : DbContext
    {
        public COLLEGE_MANAGEMENTEntities1()
            : base("name=COLLEGE_MANAGEMENTEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<giang_vien> giang_vien { get; set; }
        public virtual DbSet<hoc_ky> hoc_ky { get; set; }
        public virtual DbSet<hoc_vien> hoc_vien { get; set; }
        public virtual DbSet<lop_hoc> lop_hoc { get; set; }
        public virtual DbSet<mon_hoc> mon_hoc { get; set; }
        public virtual DbSet<nhan_vien> nhan_vien { get; set; }
        public virtual DbSet<sinh_vien> sinh_vien { get; set; }
        public virtual DbSet<tai_khoan> tai_khoan { get; set; }
    }
}
