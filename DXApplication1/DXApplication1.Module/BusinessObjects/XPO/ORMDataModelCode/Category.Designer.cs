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
namespace DXApplication1.Module.BusinessObjects.XPO.ORMDataModel
{

    public partial class Category : XPObject
    {
        string _CategoryName;
        public string CategoryName
        {
            get { return _CategoryName; }
            set { SetPropertyValue<string>(nameof(CategoryName), ref _CategoryName, value); }
        }
        string _Description;
        public string Description
        {
            get { return _Description; }
            set { SetPropertyValue<string>(nameof(Description), ref _Description, value); }
        }
        [Association(@"ProductReferencesCategory")]
        public XPCollection<Product> Products { get { return GetCollection<Product>(nameof(Products)); } }
    }

}