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
    public partial class TaxesType
    {
        private TaxType[] taxField;
        private string currencyCodeField;
        private decimal amountField;
        private bool amountFieldSpecified;

        [XmlElementAttribute("Tax", Order = 0)]
        public TaxType[] Tax
        {
            get { return this.taxField; }
            set { this.taxField = value; }
        }

        [XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get { return this.currencyCodeField; }
            set { this.currencyCodeField = value; }
        }

        [XmlAttributeAttribute()]
        public decimal Amount
        {
            get { return this.amountField; }
            set { this.amountField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool AmountSpecified
        {
            get { return this.amountFieldSpecified; }
            set { this.amountFieldSpecified = value; }
        }
    }
}