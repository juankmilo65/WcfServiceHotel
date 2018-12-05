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
    public partial class PaymentCardType
    {
        private string cardHolderNameField;
        private PaymentCardTypeCardNumber cardNumberField;
        private string cardCodeField;
        private string effectiveDateField;
        private string expireDateField;

        [XmlElementAttribute(Order = 0)]
        public string CardHolderName
        {
            get { return this.cardHolderNameField; }
            set { this.cardHolderNameField = value; }
        }

        [XmlElementAttribute(Order = 1)]
        public PaymentCardTypeCardNumber CardNumber
        {
            get { return this.cardNumberField; }
            set { this.cardNumberField = value; }
        }

        [XmlAttributeAttribute()]
        public string CardCode
        {
            get { return this.cardCodeField; }
            set { this.cardCodeField = value; }
        }

        [XmlAttributeAttribute()]
        public string EffectiveDate
        {
            get { return this.effectiveDateField; }
            set { this.effectiveDateField = value; }
        }

        [XmlAttributeAttribute()]
        public string ExpireDate
        {
            get { return this.expireDateField; }
            set { this.expireDateField = value; }
        }
    }
}