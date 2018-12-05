using System;
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
    public partial class TransportInfoTypeTransportInfo
    {
        private string typeField;
        private string idField;
        private System.DateTime timeField;
        private bool timeFieldSpecified;

        [XmlAttributeAttribute()]
        public string Type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        [XmlAttributeAttribute()]
        public string ID
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        [XmlAttributeAttribute()]
        public System.DateTime Time
        {
            get { return this.timeField; }
            set { this.timeField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool TimeSpecified
        {
            get { return this.timeFieldSpecified; }
            set { this.timeFieldSpecified = value; }
        }
    }
}