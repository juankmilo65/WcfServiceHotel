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
    public class RESX_RequestorID__UniqueID_Type
    {
        private string idField;

        [XmlAttributeAttribute()]
        public string ID
        {
            get { return this.idField; }
            set { this.idField = value; }
        }
    }
}