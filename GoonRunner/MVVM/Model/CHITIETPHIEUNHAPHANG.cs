//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GoonRunner.MVVM.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class CHITIETPHIEUNHAPHANG
    {
        public string MaPNH { get; set; }
        public string MaSP { get; set; }
        public string TenSP { get; set; }
        public Nullable<int> SoLuongNhap { get; set; }
        public Nullable<int> DonGia { get; set; }
        public Nullable<int> ThanhTien { get; set; }
    
        public virtual PHIEUNHAPHANG PHIEUNHAPHANG { get; set; }
        public virtual SANPHAM SANPHAM { get; set; }
    }
}
