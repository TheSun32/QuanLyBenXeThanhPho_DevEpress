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

    public partial class QuanLyBenXe : XPObject
    {
        string fTenQuanLy;
        public string TenQuanLy
        {
            get { return fTenQuanLy; }
            set { SetPropertyValue<string>(nameof(TenQuanLy), ref fTenQuanLy, value); }
        }
        string fEmail;
        public string Email
        {
            get { return fEmail; }
            set { SetPropertyValue<string>(nameof(Email), ref fEmail, value); }
        }
        string fSoDT;
        public string SoDT
        {
            get { return fSoDT; }
            set { SetPropertyValue<string>(nameof(SoDT), ref fSoDT, value); }
        }
        string fDiaChi;
        public string DiaChi
        {
            get { return fDiaChi; }
            set { SetPropertyValue<string>(nameof(DiaChi), ref fDiaChi, value); }
        }
    }

}
