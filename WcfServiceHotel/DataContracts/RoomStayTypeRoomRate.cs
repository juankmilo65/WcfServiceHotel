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
    public partial class RoomStayTypeRoomRate
    {
        private ServiceRPHsTypeServiceRPH[] serviceRPHsField;

        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("ServiceRPH", IsNullable = false)]
        public ServiceRPHsTypeServiceRPH[] ServiceRPHs
        {
            get { return this.serviceRPHsField; }
            set { this.serviceRPHsField = value; }
        }
    }
}