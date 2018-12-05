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
    public partial class GuaranteeType
    {
        private GuaranteeTypeGuaranteeAccepted[] guaranteesAcceptedField;
        private FormattedTextTextType[][] guaranteeDescriptionField;
        private string guaranteeCodeField;
        private GuaranteeTypeGuaranteeType guaranteeType1Field;
        private bool guaranteeType1FieldSpecified;

        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("GuaranteeAccepted", IsNullable = false)]
        public GuaranteeTypeGuaranteeAccepted[] GuaranteesAccepted
        {
            get { return this.guaranteesAcceptedField; }
            set { this.guaranteesAcceptedField = value; }
        }

        [XmlArrayAttribute(Order = 1)]
        [XmlArrayItemAttribute("Text", typeof(FormattedTextTextType), IsNullable = false)]
        public FormattedTextTextType[][] GuaranteeDescription
        {
            get { return this.guaranteeDescriptionField; }
            set { this.guaranteeDescriptionField = value; }
        }

        [XmlAttributeAttribute()]
        public string GuaranteeCode
        {
            get { return this.guaranteeCodeField; }
            set { this.guaranteeCodeField = value; }
        }

        [XmlAttributeAttribute("GuaranteeType")]
        public GuaranteeTypeGuaranteeType GuaranteeType1
        {
            get { return this.guaranteeType1Field; }
            set { this.guaranteeType1Field = value; }
        }

        public bool GuaranteeType1Specified
        {
            get { return this.guaranteeType1FieldSpecified; }
            set { this.guaranteeType1FieldSpecified = value; }
        }
    }
}