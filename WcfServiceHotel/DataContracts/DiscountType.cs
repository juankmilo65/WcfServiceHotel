using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WcfServiceHotel.DataContracts
{
    [GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class DiscountType: TotalType
    {
        private FormattedTextTextType[] discountReasonField;
        private bool taxInclusiveField;
        private bool taxInclusiveFieldSpecified;
        private decimal percentField;
        private bool percentFieldSpecified;
        private string discountCodeField;

        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("Text", IsNullable = false)]
        public FormattedTextTextType[] DiscountReason
        {
            get{return this.discountReasonField;}
            set{this.discountReasonField = value;}
        }

        [XmlAttributeAttribute()]
        public bool TaxInclusive
        {
            get{return this.taxInclusiveField;}
            set{this.taxInclusiveField = value;}
        }

        [XmlIgnoreAttribute()]
        public bool TaxInclusiveSpecified
        {
            get{return this.taxInclusiveFieldSpecified;}
            set{this.taxInclusiveFieldSpecified = value;}
        }

        [XmlAttributeAttribute()]
        public decimal Percent
        {
            get{return this.percentField;}
            set{this.percentField = value;}
        }

        [XmlIgnoreAttribute()]
        public bool PercentSpecified
        {
            get{return this.percentFieldSpecified;}
            set{this.percentFieldSpecified = value;}
        }

        [XmlAttributeAttribute()]
        public string DiscountCode
        {
            get{return this.discountCodeField;}
            set{this.discountCodeField = value;}
        }
    }
}