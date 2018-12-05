﻿using System;
using System.CodeDom.Compiler;
using System.Xml.Serialization;

namespace WcfServiceHotel.Utilities
{
    [GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [SerializableAttribute()]
    [XmlTypeAttribute(Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public enum TimeUnitType
    {
        Year,
        Month,
        Week,
        Day,
        Hour,
        Second,
        FullDuration,
        Minute,
    }
}