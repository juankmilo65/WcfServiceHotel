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
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class RESX_DepositPayments_RequiredPaymentsTypeGuaranteePaymentDeadline
    {
        private string absoluteDeadlineField;
        private TimeUnitType offsetTimeUnitField;
        private bool offsetTimeUnitFieldSpecified;
        private string offsetUnitMultiplierField;
        private RESX_DepositPayments_RequiredPaymentsTypeGuaranteePaymentDeadlineOffsetDropTime offsetDropTimeField;
        private bool offsetDropTimeFieldSpecified;

        [XmlAttributeAttribute()]
        public string AbsoluteDeadline
        {
            get { return this.absoluteDeadlineField; }
            set { this.absoluteDeadlineField = value; }
        }

        [XmlAttributeAttribute()]
        public TimeUnitType OffsetTimeUnit
        {
            get { return this.offsetTimeUnitField; }
            set { this.offsetTimeUnitField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool OffsetTimeUnitSpecified
        {
            get { return this.offsetTimeUnitFieldSpecified; }
            set { this.offsetTimeUnitFieldSpecified = value; }
        }

        [XmlAttributeAttribute(DataType = "integer")]
        public string OffsetUnitMultiplier
        {
            get { return this.offsetUnitMultiplierField; }
            set { this.offsetUnitMultiplierField = value; }
        }

        [XmlAttributeAttribute()]
        public RESX_DepositPayments_RequiredPaymentsTypeGuaranteePaymentDeadlineOffsetDropTime OffsetDropTime
        {
            get { return this.offsetDropTimeField; }
            set { this.offsetDropTimeField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool OffsetDropTimeSpecified
        {
            get { return this.offsetDropTimeFieldSpecified; }
            set { this.offsetDropTimeFieldSpecified = value; }
        }
    }
}