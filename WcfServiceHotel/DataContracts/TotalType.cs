using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace WcfServiceHotel.DataContracts
{
    [XmlIncludeAttribute(typeof(DiscountType))]
    [GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class TotalType
    {
        private TaxesType taxesField;
        private decimal amountBeforeTaxField;
        private bool amountBeforeTaxFieldSpecified;
        private decimal amountAfterTaxField;
        private bool amountAfterTaxFieldSpecified;
        private string currencyCodeField;

        [XmlElementAttribute(Order = 0)]
        public TaxesType Taxes
        {
            get { return this.taxesField; }
            set { this.taxesField = value; }
        }

        [XmlAttributeAttribute()]
        public decimal AmountBeforeTax
        {
            get { return this.amountBeforeTaxField; }
            set { this.amountBeforeTaxField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool AmountBeforeTaxSpecified
        {
            get { return this.amountBeforeTaxFieldSpecified; }
            set { this.amountBeforeTaxFieldSpecified = value; }
        }

        [XmlAttributeAttribute()]
        public decimal AmountAfterTax
        {
            get { return this.amountAfterTaxField; }
            set { this.amountAfterTaxField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool AmountAfterTaxSpecified
        {
            get { return this.amountAfterTaxFieldSpecified; }
            set { this.amountAfterTaxFieldSpecified = value; }
        }

        [XmlAttributeAttribute()]
        public string CurrencyCode
        {
            get { return this.currencyCodeField; }
            set { this.currencyCodeField = value; }
        }
    }
}