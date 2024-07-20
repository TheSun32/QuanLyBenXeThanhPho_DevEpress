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

    public partial class XeCoDinh : XPObject
    {
        string fIdXe;
        [DevExpress.Xpo.DisplayName(@"Id Xe")]
        public string IdXe
        {
            get { return fIdXe; }
            set { SetPropertyValue<string>(nameof(IdXe), ref fIdXe, value); }
        }
        string fLoaiXe;
        [DevExpress.Xpo.DisplayName(@"Loại Xe")]
        public string LoaiXe
        {
            get { return fLoaiXe; }
            set { SetPropertyValue<string>(nameof(LoaiXe), ref fLoaiXe, value); }
        }
        string fBienSo;
        [DevExpress.Xpo.DisplayName(@"Biển Số")]
        public string BienSo
        {
            get { return fBienSo; }
            set { SetPropertyValue<string>(nameof(BienSo), ref fBienSo, value); }
        }
        string fSoChoNgoi;
        [DevExpress.Xpo.DisplayName(@"Số Chỗ Ngồi")]
        public string SoChoNgoi
        {
            get { return fSoChoNgoi; }
            set { SetPropertyValue<string>(nameof(SoChoNgoi), ref fSoChoNgoi, value); }
        }
        DateTime fNgayCapThe;
        [DevExpress.Xpo.DisplayName(@"Ngày Cấp Thẻ")]
        public DateTime NgayCapThe
        {
            get { return fNgayCapThe; }
            set { SetPropertyValue<DateTime>(nameof(NgayCapThe), ref fNgayCapThe, value); }
        }
        string fNhaXe;
        [DevExpress.Xpo.DisplayName(@"Nhà Xe")]
        public string NhaXe
        {
            get { return fNhaXe; }
            set { SetPropertyValue<string>(nameof(NhaXe), ref fNhaXe, value); }
        }
        string fSoLuotConLai;
        [DevExpress.Xpo.DisplayName(@"Số Lượt Còn Lại")]
        public string SoLuotConLai
        {
            get { return fSoLuotConLai; }
            set { SetPropertyValue<string>(nameof(SoLuotConLai), ref fSoLuotConLai, value); }
        }
        NhaXe fIdNhaXe;
        [Association(@"XeCoDinhReferencesNhaXe")]
        [DevExpress.Xpo.DisplayName(@"Id Nhà Xe")]
        public NhaXe IdNhaXe
        {
            get { return fIdNhaXe; }
            set { SetPropertyValue<NhaXe>(nameof(IdNhaXe), ref fIdNhaXe, value); }
        }
        [Association(@"BangLichTrinhReferencesXeCoDinh"), Aggregated]
        public XPCollection<BangLichTrinh> BangLichTrinhs { get { return GetCollection<BangLichTrinh>(nameof(BangLichTrinhs)); } }
        [Association(@"LichSuRaVaoReferencesXeCoDinh"), Aggregated]
        public XPCollection<LichSuRaVao> LichSuRaVaos { get { return GetCollection<LichSuRaVao>(nameof(LichSuRaVaos)); } }
    }

}
