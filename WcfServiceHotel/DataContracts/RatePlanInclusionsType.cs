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
    public partial class RatePlanInclusionsType
    {
        private FormattedTextTextType[] ratePlanInclusionDescriptionField;
        private bool taxInclusiveField;
        private bool taxInclusiveFieldSpecified;
        private bool serviceFeeInclusiveField;
        private bool serviceFeeInclusiveFieldSpecified;

        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("Text", IsNullable = false)]
        public FormattedTextTextType[] RatePlanInclusionDescription
        {
            get { return this.ratePlanInclusionDescriptionField; }
            set { this.ratePlanInclusionDescriptionField = value; }
        }

        [XmlAttributeAttribute()]
        public bool TaxInclusive
        {
            get { return this.taxInclusiveField; }
            set { this.taxInclusiveField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool TaxInclusiveSpecified
        {
            get { return this.taxInclusiveFieldSpecified; }
            set { this.taxInclusiveFieldSpecified = value; }
        }

        [XmlAttributeAttribute()]
        public bool ServiceFeeInclusive
        {
            get { return this.serviceFeeInclusiveField; }
            set { this.serviceFeeInclusiveField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool ServiceFeeInclusiveSpecified
        {
            get { return this.serviceFeeInclusiveFieldSpecified; }
            set { this.serviceFeeInclusiveFieldSpecified = value; }
        }
    }
}