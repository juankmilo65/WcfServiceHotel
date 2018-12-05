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
    public partial class PaymentCardTypeCardNumber
    {
        private string plainTextField;
        private string maskField;
        private string tokenField;
        private string tokenProviderIDField;

        [XmlElementAttribute(Order = 0)]
        public string PlainText
        {
            get { return this.plainTextField; }
            set { this.plainTextField = value; }
        }

        [XmlAttributeAttribute()]
        public string Mask
        {
            get { return this.maskField; }
            set { this.maskField = value; }
        }

        [XmlAttributeAttribute()]
        public string Token
        {
            get { return this.tokenField; }
            set { this.tokenField = value; }
        }

        [XmlAttributeAttribute()]
        public string TokenProviderID
        {
            get { return this.tokenProviderIDField; }
            set { this.tokenProviderIDField = value; }
        }
    }
}