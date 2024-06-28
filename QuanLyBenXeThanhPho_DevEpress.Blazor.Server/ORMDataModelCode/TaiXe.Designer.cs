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

    public partial class TaiXe : XPObject
    {
        string fIdTaiXe;
        [DevExpress.Xpo.DisplayName(@"Id Tài Xế")]
        public string IdTaiXe
        {
            get { return fIdTaiXe; }
            set { SetPropertyValue<string>(nameof(IdTaiXe), ref fIdTaiXe, value); }
        }
        string fTenTaiXe;
        [DevExpress.Xpo.DisplayName(@"Tên Tài Xế")]
        public string TenTaiXe
        {
            get { return fTenTaiXe; }
            set { SetPropertyValue<string>(nameof(TenTaiXe), ref fTenTaiXe, value); }
        }
        string fTaiKhoan;
        [DevExpress.Xpo.DisplayName(@"Tài Khoản")]
        public string TaiKhoan
        {
            get { return fTaiKhoan; }
            set { SetPropertyValue<string>(nameof(TaiKhoan), ref fTaiKhoan, value); }
        }
        string fMatKhau;
        [DevExpress.Xpo.DisplayName(@"Mật Khẩu")]
        public string MatKhau
        {
            get { return fMatKhau; }
            set { SetPropertyValue<string>(nameof(MatKhau), ref fMatKhau, value); }
        }
        string fSoDT;
        [DevExpress.Xpo.DisplayName(@"Số Điện Thoại")]
        public string SoDT
        {
            get { return fSoDT; }
            set { SetPropertyValue<string>(nameof(SoDT), ref fSoDT, value); }
        }
        string fDiaChi;
        [DevExpress.Xpo.DisplayName(@"Địa Chỉ")]
        public string DiaChi
        {
            get { return fDiaChi; }
            set { SetPropertyValue<string>(nameof(DiaChi), ref fDiaChi, value); }
        }
        string fSoCCCD;
        [DevExpress.Xpo.DisplayName(@"Số Căn Cước Công Dân")]
        public string SoCCCD
        {
            get { return fSoCCCD; }
            set { SetPropertyValue<string>(nameof(SoCCCD), ref fSoCCCD, value); }
        }
        string fGiayPhepLaiXe;
        [DevExpress.Xpo.DisplayName(@"Giấy Phép Lái Xe")]
        public string GiayPhepLaiXe
        {
            get { return fGiayPhepLaiXe; }
            set { SetPropertyValue<string>(nameof(GiayPhepLaiXe), ref fGiayPhepLaiXe, value); }
        }
        DateTime fNgayKiHopDong;
        [DevExpress.Xpo.DisplayName(@"Ngày Kí hợp Đồng")]
        public DateTime NgayKiHopDong
        {
            get { return fNgayKiHopDong; }
            set { SetPropertyValue<DateTime>(nameof(NgayKiHopDong), ref fNgayKiHopDong, value); }
        }
        DateTime fThoiHanHopDong;
        [DevExpress.Xpo.DisplayName(@"Thời Hạn Hợp Đồng")]
        public DateTime ThoiHanHopDong
        {
            get { return fThoiHanHopDong; }
            set { SetPropertyValue<DateTime>(nameof(ThoiHanHopDong), ref fThoiHanHopDong, value); }
        }
        NhaXe fIdNhaXe;
        [Association(@"TaiXeReferencesNhaXe")]
        [DevExpress.Xpo.DisplayName(@"Id Nhà Xe")]
        public NhaXe IdNhaXe
        {
            get { return fIdNhaXe; }
            set { SetPropertyValue<NhaXe>(nameof(IdNhaXe), ref fIdNhaXe, value); }
        }
        [Association(@"BangLichTrinhReferencesTaiXe"), Aggregated]
        public XPCollection<BangLichTrinh> BangLichTrinhs { get { return GetCollection<BangLichTrinh>(nameof(BangLichTrinhs)); } }
    }

}
