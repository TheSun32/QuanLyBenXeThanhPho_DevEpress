﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace QuanLyBenXeThanhPho_DevEpress.Blazor.Server.ORMDataModel
{

    public partial class NhanVienSoatVe : XPObject
    {
        string fIdNhanVien;
        [DevExpress.Xpo.DisplayName(@"Id Nhân Viên")]
        public string IdNhanVien
        {
            get { return fIdNhanVien; }
            set { SetPropertyValue<string>(nameof(IdNhanVien), ref fIdNhanVien, value); }
        }
        string fTenNhanVien;
        [DevExpress.Xpo.DisplayName(@"Tên Nhân Viên")]
        public string TenNhanVien
        {
            get { return fTenNhanVien; }
            set { SetPropertyValue<string>(nameof(TenNhanVien), ref fTenNhanVien, value); }
        }
        string fTaiKhoan;
        [DevExpress.Xpo.DisplayName(@"Tài Khoản")]
        public string TaiKhoan
        {
            get { return fTaiKhoan; }
            set { SetPropertyValue<string>(nameof(TaiKhoan), ref fTaiKhoan, value); }
        }
        string fSoDT;
        [DevExpress.Xpo.DisplayName(@"Số Điện Thoại")]
        public string SoDT
        {
            get { return fSoDT; }
            set { SetPropertyValue<string>(nameof(SoDT), ref fSoDT, value); }
        }
        string fSoCCCD;
        [DevExpress.Xpo.DisplayName(@"Số Căn Cước Công Dân")]
        public string SoCCCD
        {
            get { return fSoCCCD; }
            set { SetPropertyValue<string>(nameof(SoCCCD), ref fSoCCCD, value); }
        }
        string fDiaChi;
        [DevExpress.Xpo.DisplayName(@"Địa Chỉ")]
        public string DiaChi
        {
            get { return fDiaChi; }
            set { SetPropertyValue<string>(nameof(DiaChi), ref fDiaChi, value); }
        }
        [Association(@"LichSuRaVaoReferencesNhanVienSoatVe"), Aggregated]
        public XPCollection<LichSuRaVao> LichSuRaVaos { get { return GetCollection<LichSuRaVao>(nameof(LichSuRaVaos)); } }
        [Association(@"BangBaoCaoReferencesNhanVienSoatVe"), Aggregated]
        public XPCollection<BangBaoCao> BangBaoCaos { get { return GetCollection<BangBaoCao>(nameof(BangBaoCaos)); } }
    }

}
