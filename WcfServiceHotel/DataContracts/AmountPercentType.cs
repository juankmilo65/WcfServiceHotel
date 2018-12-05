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
    public partial class AmountPercentType
    {
        private TaxesType taxesField;
        private decimal percentField;
        private bool percentFieldSpecified;
        private string currencyCodeField;
        private decimal amountField;
        private bool amountFieldSpecified;
        private string nmbrOfNightsField;

        [XmlElementAttribute(Order = 0)]
        public TaxesType Taxes
        {
            get { return this.taxesField; }
            set { this.taxesField = value; }
        }

        [XmlAttributeAttribute()]
        public decimal Percent
        {
            get { return this.percentField; }
            set { this.percentField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool PercentSpecified
        {
            get { return this.percentFieldSpecified; }
            set { this.percentFieldSpecified = value; }
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

        [XmlAttributeAttribute(DataType = "nonNegativeInteger")]
        public string NmbrOfNights
        {
            get { return this.nmbrOfNightsField; }
            set { this.nmbrOfNightsField = value; }
        }
    }
}