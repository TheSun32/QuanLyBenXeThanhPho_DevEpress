﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using DevExpress.Persistent.Base;
namespace QuanLyBenXeThanhPho_DevEpress.Blazor.Server.ORMDataModel
{
    [DefaultClassOptions]
    public partial class YeuCau
    {
        public YeuCau(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
