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

    public partial class Order : XPObject
    {
        DateTime _OrderDate;
      
        public DateTime OrderDate
        {
            get { return _OrderDate; }
            set { SetPropertyValue<DateTime>(nameof(OrderDate), ref _OrderDate, value); }
        }
        decimal _Freight;
        //[RuleValueComparison("", DefaultContexts.Save, ValueComparisonType.GreaterThan, 0)]
        public decimal Freight
        {
            get { return _Freight; }
            set { SetPropertyValue<decimal>(nameof(Freight), ref _Freight, value); }
        }
        Customer _Customer;
        [Association(@"OrderReferencesCustomer")]
        public Customer Customer
        {
            get { return _Customer; }
            set { SetPropertyValue<Customer>(nameof(Customer), ref _Customer, value); }
        }
        [Association(@"ItemsReferencesOrder")]
        public XPCollection<Items> ItemsCollection { get { return GetCollection<Items>(nameof(ItemsCollection)); } }
    }

}
