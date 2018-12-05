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
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class RESX_ResGuest__CustomerTypeCustLoyalty
    {
        private string programIDField;
        private string membershipIDField;
        private string loyalLevelField;
        private string loyalLevelCodeField;
        private DateTime signupDateField;
        private bool signupDateFieldSpecified;
        private DateTime effectiveDateField;
        private bool effectiveDateFieldSpecified;
        private DateTime expireDateField;
        private bool expireDateFieldSpecified;
        private string remarkField;

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ProgramID
        {
            get { return this.programIDField; }
            set { this.programIDField = value; }
        }

        [XmlAttributeAttribute()]
        public string MembershipID
        {
            get { return this.membershipIDField; }
            set { this.membershipIDField = value; }
        }

        [XmlAttributeAttribute()]
        public string LoyalLevel
        {
            get { return this.loyalLevelField; }
            set { this.loyalLevelField = value; }
        }

        [XmlAttributeAttribute(DataType = "integer")]
        public string LoyalLevelCode
        {
            get { return this.loyalLevelCodeField; }
            set { this.loyalLevelCodeField = value; }
        }

        [XmlAttributeAttribute(DataType = "date")]
        public System.DateTime SignupDate
        {
            get { return this.signupDateField; }
            set { this.signupDateField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool SignupDateSpecified
        {
            get { return this.signupDateFieldSpecified; }
            set { this.signupDateFieldSpecified = value; }
        }

        [XmlAttributeAttribute(DataType = "date")]
        public System.DateTime EffectiveDate
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
        public string Remark
        {
            get { return this.remarkField; }
            set { this.remarkField = value; }
        }
    }
}