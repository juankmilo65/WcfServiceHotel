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
    [XmlTypeAttribute(Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class CompanyNameType
    {
        private string codeField;
        private string valueField;

        [XmlAttributeAttribute()]
        public string Code
        {
            get { return this.codeField; }
            set { this.codeField = value; }
        }

        [XmlTextAttribute()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }
}