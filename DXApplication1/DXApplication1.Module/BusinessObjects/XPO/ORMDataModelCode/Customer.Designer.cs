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
using DevExpress.Persistent.Validation;

namespace DXApplication1.Module.BusinessObjects.XPO.ORMDataModel
{

    public partial class Customer : XPObject
    {
        string _FirstName;
        [RuleRequiredField("FirstNameRequired", DefaultContexts.Save)]
        public string FirstName
        {
            get { return _FirstName; }
            set { SetPropertyValue<string>(nameof(FirstName), ref _FirstName, value); }
        }
        string _LastName;
        public string LastName
        {
            get { return _LastName; }
            set { SetPropertyValue<string>(nameof(LastName), ref _LastName, value); }
        }
        [PersistentAlias("[FirstName] + ' ' + [LastName]")]
        public string FullName
        {
            get { return (string)(EvaluateAlias(nameof(FullName))); }
        }
        [Association(@"OrderReferencesCustomer")]
        public XPCollection<Order> Orders { get { return GetCollection<Order>(nameof(Orders)); } }
    }

}