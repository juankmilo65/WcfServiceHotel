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
    public partial class ErrorType
    {
        private string typeField;
        private string shortTextField;
        private string codeField;
        private string docURLField;
        private string statusField;
        private string tagField;
        private string recordIDField;
        private string nodeListField;

        [XmlAttributeAttribute()]
        public string Type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        [XmlAttributeAttribute()]
        public string ShortText
        {
            get { return this.shortTextField; }
            set { this.shortTextField = value; }
        }

        [XmlAttributeAttribute()]
        public string Code
        {
            get { return this.codeField; }
            set { this.codeField = value; }
        }

        [XmlAttributeAttribute(DataType = "anyURI")]
        public string DocURL
        {
            get { return this.docURLField; }
            set { this.docURLField = value; }
        }

        [XmlAttributeAttribute()]
        public string Status
        {
            get { return this.statusField; }
            set { this.statusField = value; }
        }

        [XmlAttributeAttribute()]
        public string Tag
        {
            get { return this.tagField; }
            set { this.tagField = value; }
        }

        [XmlAttributeAttribute()]
        public string RecordID
        {
            get { return this.recordIDField; }
            set { this.recordIDField = value; }
        }

        [XmlAttributeAttribute()]
        public string NodeList
        {
            get { return this.nodeListField; }
            set { this.nodeListField = value; }
        }
    }
}