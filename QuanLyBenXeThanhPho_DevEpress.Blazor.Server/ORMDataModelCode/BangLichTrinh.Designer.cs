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

    public partial class BangLichTrinh : XPObject
    {
        string fIdLichTrinh;
        public string IdLichTrinh
        {
            get { return fIdLichTrinh; }
            set { SetPropertyValue<string>(nameof(IdLichTrinh), ref fIdLichTrinh, value); }
        }
        string fGioXuatPhat;
        public string GioXuatPhat
        {
            get { return fGioXuatPhat; }
            set { SetPropertyValue<string>(nameof(GioXuatPhat), ref fGioXuatPhat, value); }
        }
        string fDiemDen;
        public string DiemDen
        {
            get { return fDiemDen; }
            set { SetPropertyValue<string>(nameof(DiemDen), ref fDiemDen, value); }
        }
        string fGiaVe;
        public string GiaVe
        {
            get { return fGiaVe; }
            set { SetPropertyValue<string>(nameof(GiaVe), ref fGiaVe, value); }
        }
        TaiXe fIdTaiXe;
        [Association(@"BangLichTrinhReferencesTaiXe")]
        public TaiXe IdTaiXe
        {
            get { return fIdTaiXe; }
            set { SetPropertyValue<TaiXe>(nameof(IdTaiXe), ref fIdTaiXe, value); }
        }
        XeCoDinh fIdXe;
        [Association(@"BangLichTrinhReferencesXeCoDinh")]
        public XeCoDinh IdXe
        {
            get { return fIdXe; }
            set { SetPropertyValue<XeCoDinh>(nameof(IdXe), ref fIdXe, value); }
        }
    }

}