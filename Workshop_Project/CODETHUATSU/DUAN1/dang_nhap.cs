//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class dang_nhap
    {
        public string tai_khoan { get; set; }
        public string mat_khau { get; set; }
        public string role { get; set; }
        public string ma_nv { get; set; }
    
        public virtual nhan_vien nhan_vien { get; set; }
    }
}