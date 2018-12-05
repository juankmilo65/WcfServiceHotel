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
    public partial class AdditionalDetailType
    {
        private FormattedTextTextType[] detailDescriptionField;
        private string typeField;
        private string codeField;

        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("Text", IsNullable = false)]
        public FormattedTextTextType[] DetailDescription
        {
            get { return this.detailDescriptionField; }
            set { this.detailDescriptionField = value; }
        }

        [XmlAttributeAttribute()]
        public string Type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        [XmlAttributeAttribute()]
        public string Code
        {
            get { return this.codeField; }
            set { this.codeField = value; }
        }
    }
}