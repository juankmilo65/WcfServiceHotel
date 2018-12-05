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
    [XmlTypeAttribute(Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class EmailType
    {

        private bool defaultIndField;
        private bool defaultIndFieldSpecified;
        private string emailType1Field;
        private string valueField;

        [XmlAttributeAttribute()]
        public bool DefaultInd
        {
            get { return this.defaultIndField; }
            set { this.defaultIndField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool DefaultIndSpecified
        {
            get { return this.defaultIndFieldSpecified; }
            set { this.defaultIndFieldSpecified = value; }
        }

        [XmlAttributeAttribute("EmailType")]
        public string EmailType1
        {
            get { return this.emailType1Field; }
            set { this.emailType1Field = value; }
        }

        [XmlTextAttribute()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }
}