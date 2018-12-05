using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WcfServiceHotel.DataContracts
{
    [GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class SourceType
    {
        private object itemField;

        /// <remarks/>
        [XmlElementAttribute("BookingChannel", typeof(SourceTypeBookingChannel), Order = 0)]
        [XmlElementAttribute("RequestorID", typeof(SourceTypeRequestorID), Order = 0)]
        public object Item
        {
            get { return this.itemField; }
            set { this.itemField = value; }
        }
    }
}