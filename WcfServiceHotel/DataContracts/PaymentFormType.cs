using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using WcfServiceHotel.Utilities;

namespace WcfServiceHotel.DataContracts
{
    [GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class PaymentFormType
    {
        private object itemField;
        private PaymentFormTypePaymentTransactionTypeCode paymentTransactionTypeCodeField;
        private bool paymentTransactionTypeCodeFieldSpecified;

        [XmlElementAttribute("DirectBill", typeof(DirectBillType), Order = 0)]
        [XmlElementAttribute("PaymentCard", typeof(PaymentCardType), Order = 0)]
        [XmlElementAttribute("Voucher", typeof(PaymentFormTypeVoucher), Order = 0)]
        public object Item
        {
            get { return this.itemField; }
            set { this.itemField = value; }
        }

        /// <remarks/>
        [XmlAttributeAttribute()]
        public PaymentFormTypePaymentTransactionTypeCode PaymentTransactionTypeCode
        {
            get { return this.paymentTransactionTypeCodeField; }
            set { this.paymentTransactionTypeCodeField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool PaymentTransactionTypeCodeSpecified
        {
            get { return this.paymentTransactionTypeCodeFieldSpecified; }
            set { this.paymentTransactionTypeCodeFieldSpecified = value; }
        }
    }
}