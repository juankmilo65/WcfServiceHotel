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
    public partial class RatePlanType
    {
        private FormattedTextTextType[] ratePlanDescriptionField;
        private RatePlanInclusionsType ratePlanInclusionsField;
        private RatePlanTypeMealsIncluded mealsIncludedField;
        private AdditionalDetailType[] additionalDetailsField;
        private string ratePlanCodeField;
        private System.DateTime effectiveDateField;
        private bool effectiveDateFieldSpecified;
        private System.DateTime expireDateField;
        private bool expireDateFieldSpecified;
        private string ratePlanNameField;

        /// <remarks/>
        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("Text", IsNullable = false)]
        public FormattedTextTextType[] RatePlanDescription
        {
            get { return this.ratePlanDescriptionField; }
            set { this.ratePlanDescriptionField = value; }
        }

        /// <remarks/>
        [XmlElementAttribute(Order = 1)]
        public RatePlanInclusionsType RatePlanInclusions
        {
            get { return this.ratePlanInclusionsField; }
            set { this.ratePlanInclusionsField = value; }
        }

        [XmlElementAttribute(Order = 2)]
        public RatePlanTypeMealsIncluded MealsIncluded
        {
            get { return this.mealsIncludedField; }
            set { this.mealsIncludedField = value; }
        }

        [XmlArrayAttribute(Order = 3)]
        [XmlArrayItemAttribute("AdditionalDetail", IsNullable = false)]
        public AdditionalDetailType[] AdditionalDetails
        {
            get { return this.additionalDetailsField; }
            set { this.additionalDetailsField = value; }
        }

        [XmlAttributeAttribute()]
        public string RatePlanCode
        {
            get { return this.ratePlanCodeField; }
            set { this.ratePlanCodeField = value; }
        }

        [XmlAttributeAttribute(DataType = "date")]
        public DateTime EffectiveDate
        {
            get { return this.effectiveDateField; }
            set { this.effectiveDateField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool EffectiveDateSpecified
        {
            get { return this.effectiveDateFieldSpecified; }
            set { this.effectiveDateFieldSpecified = value; }
        }

        [XmlAttributeAttribute(DataType = "date")]
        public DateTime ExpireDate
        {
            get { return this.expireDateField; }
            set { this.expireDateField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool ExpireDateSpecified
        {
            get { return this.expireDateFieldSpecified; }
            set { this.expireDateFieldSpecified = value; }
        }

        [XmlAttributeAttribute()]
        public string RatePlanName
        {
            get { return this.ratePlanNameField; }
            set { this.ratePlanNameField = value; }
        }
    }
}