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
    public partial class RESX_ResGuest__CustomerType
    {
        private PersonNameType[] personNameField;
        private RESX_ResGuest__CustomerTypeTelephone[] telephoneField;
        private RESX_ResGuest__CustomerTypeEmail[] emailField;
        private RESX_ResGuest__CustomerTypeAddress[] addressField;
        private RelatedTravelerType[] relatedTravelerField;
        private RESX_ResGuest__CustomerTypeCustLoyalty[] custLoyaltyField;
        private DateTime birthDateField;
        private bool birthDateFieldSpecified;
        private bool vIP_IndicatorField;
        private bool vIP_IndicatorFieldSpecified;
        private string customerValueField;

        [XmlElementAttribute("PersonName", Order = 0)]
        public PersonNameType[] PersonName
        {
            get { return this.personNameField; }
            set { this.personNameField = value; }
        }

        [XmlElementAttribute("Telephone", Order = 1)]
        public RESX_ResGuest__CustomerTypeTelephone[] Telephone
        {
            get { return this.telephoneField; }
            set { this.telephoneField = value; }
        }

        [XmlElementAttribute("Email", Order = 2)]
        public RESX_ResGuest__CustomerTypeEmail[] Email
        {
            get { return this.emailField; }
            set { this.emailField = value; }
        }

        [XmlElementAttribute("Address", Order = 3)]
        public RESX_ResGuest__CustomerTypeAddress[] Address
        {
            get { return this.addressField; }
            set { this.addressField = value; }
        }

        [XmlElementAttribute("RelatedTraveler", Order = 4)]
        public RelatedTravelerType[] RelatedTraveler
        {
            get { return this.relatedTravelerField; }
            set { this.relatedTravelerField = value; }
        }

        [XmlElementAttribute("CustLoyalty", Order = 5)]
        public RESX_ResGuest__CustomerTypeCustLoyalty[] CustLoyalty
        {
            get { return this.custLoyaltyField; }
            set { this.custLoyaltyField = value; }
        }

        [XmlAttributeAttribute(DataType = "date")]
        public System.DateTime BirthDate
        {
            get { return this.birthDateField; }
            set { this.birthDateField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool BirthDateSpecified
        {
            get { return this.birthDateFieldSpecified; }
            set { this.birthDateFieldSpecified = value; }
        }

        [XmlAttributeAttribute()]
        public bool VIP_Indicator
        {
            get { return this.vIP_IndicatorField; }
            set { this.vIP_IndicatorField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool VIP_IndicatorSpecified
        {
            get { return this.vIP_IndicatorFieldSpecified; }
            set { this.vIP_IndicatorFieldSpecified = value; }
        }

        [XmlAttributeAttribute()]
        public string CustomerValue
        {
            get { return this.customerValueField; }
            set { this.customerValueField = value; }
        }
    }
}