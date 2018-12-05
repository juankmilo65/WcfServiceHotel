﻿using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace WcfServiceHotel.DataContracts
{
    [GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class PaymentFormTypeVoucher
    {
        private string seriesCodeField;

        [XmlAttributeAttribute()]
        public string SeriesCode
        {
            get { return this.seriesCodeField; }
            set { this.seriesCodeField = value; }
        }
    }
}