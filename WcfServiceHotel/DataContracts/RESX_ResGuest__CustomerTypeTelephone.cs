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
    public partial class RESX_ResGuest__CustomerTypeTelephone
    {
        private string phoneLocationTypeField;
        private string phoneTechTypeField;
        private string countryAccessCodeField;
        private string areaCityCodeField;
        private string phoneNumberField;
        private string remarkField;
        private bool formattedIndField;
        private bool formattedIndFieldSpecified;
        private bool defaultIndField;
        private bool defaultIndFieldSpecified;

        [XmlAttributeAttribute()]
        public string PhoneLocationType
        {
            get { return this.phoneLocationTypeField; }
            set { this.phoneLocationTypeField = value; }
        }

        [XmlAttributeAttribute()]
        public string PhoneTechType
        {
            get { return this.phoneTechTypeField; }
            set { this.phoneTechTypeField = value; }
        }

        [XmlAttributeAttribute()]
        public string CountryAccessCode
        {
            get { return this.countryAccessCodeField; }
            set { this.countryAccessCodeField = value; }
        }

        [XmlAttributeAttribute()]
        public string AreaCityCode
        {
            get { return this.areaCityCodeField; }
            set { this.areaCityCodeField = value; }
        }

        [XmlAttributeAttribute()]
        public string PhoneNumber
        {
            get { return this.phoneNumberField; }
            set { this.phoneNumberField = value; }
        }

        [XmlAttributeAttribute()]
        public string Remark
        {
            get { return this.remarkField; }
            set { this.remarkField = value; }
        }

        [XmlAttributeAttribute()]
        public bool FormattedInd
        {
            get { return this.formattedIndField; }
            set { this.formattedIndField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool FormattedIndSpecified
        {
            get { return this.formattedIndFieldSpecified; }
            set { this.formattedIndFieldSpecified = value; }
        }

        [XmlAttributeAttribute()]
        public bool DefaultInd
        {
            get { return this.defaultIndField; }
            set { this.defaultIndField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool DefaultIndSpecified
        {
            get { return this.defaultIndFieldSpecified; }
            set { this.defaultIndFieldSpecified = value; }
        }
    }
}