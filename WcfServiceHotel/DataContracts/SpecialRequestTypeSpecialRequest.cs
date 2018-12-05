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
    public partial class SpecialRequestTypeSpecialRequest
    {
        private string requestCodeField;
        private string codeContextField;

        [XmlAttributeAttribute()]
        public string RequestCode
        {
            get { return this.requestCodeField; }
            set { this.requestCodeField = value; }
        }

        [XmlAttributeAttribute()]
        public string CodeContext
        {
            get { return this.codeContextField; }
            set { this.codeContextField = value; }
        }
    }
}