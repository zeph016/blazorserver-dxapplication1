﻿using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace DXApplication1.Module.BusinessObjects.XPO.ORMDataModel
{

    public partial class Items
    {
        public Items(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
