﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class GoonRunnerEntities : DbContext
    {
        public GoonRunnerEntities()
            : base("name=GoonRunnerEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACCNHANVIEN> ACCNHANVIENs { get; set; }
        public virtual DbSet<CHITIETBAOHANH> CHITIETBAOHANHs { get; set; }
        public virtual DbSet<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual DbSet<CHITIETPHIEUNHAPHANG> CHITIETPHIEUNHAPHANGs { get; set; }
        public virtual DbSet<CHUONGTRINHKHUYENMAI> CHUONGTRINHKHUYENMAIs { get; set; }
        public virtual DbSet<DANHSACHMAGIAMGIA> DANHSACHMAGIAMGIAs { get; set; }
        public virtual DbSet<GIAOCA> GIAOCAs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<NHACUNGCAP> NHACUNGCAPs { get; set; }
        public virtual DbSet<NHANVIEN> NHANVIENs { get; set; }
        public virtual DbSet<PHIEUBAOHANH> PHIEUBAOHANHs { get; set; }
        public virtual DbSet<PHIEUNHAPHANG> PHIEUNHAPHANGs { get; set; }
        public virtual DbSet<PHONGBAN> PHONGBANs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }
        public virtual DbSet<HINHNHANVIEN> HINHNHANVIENs { get; set; }
        public virtual DbSet<DoanhThuTheoNgay> DoanhThuTheoNgays { get; set; }
        public virtual DbSet<View_Test> View_Test { get; set; }
    }
}
