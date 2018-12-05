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
    public partial class RESX_DepositPayments_RequiredPaymentsTypeGuaranteePayment
    {
        private AcceptedPaymentsTypeAcceptedPayment[] acceptedPaymentsField;
        private RESX_DepositPayments_RequiredPaymentsTypeGuaranteePaymentAmountPercent amountPercentField;
        private RESX_DepositPayments_RequiredPaymentsTypeGuaranteePaymentDeadline[] deadlineField;
        private FormattedTextTextType[][] descriptionField;
        private RESX_DepositPayments_RequiredPaymentsTypeGuaranteePaymentAddress[] addressField;

        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("AcceptedPayment", IsNullable = false)]
        public AcceptedPaymentsTypeAcceptedPayment[] AcceptedPayments
        {
            get { return this.acceptedPaymentsField; }
            set { this.acceptedPaymentsField = value; }
        }

        [XmlElementAttribute(Order = 1)]
        public RESX_DepositPayments_RequiredPaymentsTypeGuaranteePaymentAmountPercent AmountPercent
        {
            get { return this.amountPercentField; }
            set { this.amountPercentField = value; }
        }

        [XmlElementAttribute("Deadline", Order = 2)]
        public RESX_DepositPayments_RequiredPaymentsTypeGuaranteePaymentDeadline[] Deadline
        {
            get { return this.deadlineField; }
            set { this.deadlineField = value; }
        }

        [XmlArrayAttribute(Order = 3)]
        [XmlArrayItemAttribute("Text", typeof(FormattedTextTextType), IsNullable = false)]
        public FormattedTextTextType[][] Description
        {
            get { return this.descriptionField; }
            set { this.descriptionField = value; }
        }

        [XmlElementAttribute("Address", Order = 4)]
        public RESX_DepositPayments_RequiredPaymentsTypeGuaranteePaymentAddress[] Address
        {
            get { return this.addressField; }
            set { this.addressField = value; }
        }

    }
}