using System;
using DevExpress.Xpo;
using DevExpress.Xpo.Metadata;
using DevExpress.Data.Filtering;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
namespace DXApplication1.Module.BusinessObjects.XPO.ORMDataModel
{
    [NavigationItem(true)]
    public partial class Category
    {
        public Category(Session session) : base(session) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

}
