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
    public partial class SourceTypeBookingChannel
    {
        private CompanyNameType companyNameField;
        private string typeField;
        private bool primaryField;
        private bool primaryFieldSpecified;

        [XmlElementAttribute(Order = 0)]
        public CompanyNameType CompanyName
        {
            get { return this.companyNameField; }
            set { this.companyNameField = value; }
        }

        [XmlAttributeAttribute()]
        public string Type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        [XmlAttributeAttribute()]
        public bool Primary
        {
            get { return this.primaryField; }
            set { this.primaryField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool PrimarySpecified
        {
            get { return this.primaryFieldSpecified; }
            set { this.primaryFieldSpecified = value; }
        }
    }
}