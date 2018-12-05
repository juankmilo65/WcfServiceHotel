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
    public partial class CompanyInfoType
    {
        private CompanyNameType[] companyNameField;
        private CompanyInfoTypeAddressInfo[] addressInfoField;
        private CompanyInfoTypeTelephoneInfo[] telephoneInfoField;
        private CompanyInfoTypeEmail[] emailField;
        private ContactPersonType[] contactPersonField;

        [XmlElementAttribute("CompanyName", Order = 0)]
        public CompanyNameType[] CompanyName
        {
            get { return this.companyNameField; }
            set { this.companyNameField = value; }
        }

        [XmlElementAttribute("AddressInfo", Order = 1)]
        public CompanyInfoTypeAddressInfo[] AddressInfo
        {
            get { return this.addressInfoField; }
            set { this.addressInfoField = value; }
        }

        [XmlElementAttribute("TelephoneInfo", Order = 2)]
        public CompanyInfoTypeTelephoneInfo[] TelephoneInfo
        {
            get { return this.telephoneInfoField; }
            set { this.telephoneInfoField = value; }
        }

        [XmlElementAttribute("Email", Order = 3)]
        public CompanyInfoTypeEmail[] Email
        {
            get { return this.emailField; }
            set { this.emailField = value; }
        }

        [XmlElementAttribute("ContactPerson", Order = 4)]
        public ContactPersonType[] ContactPerson
        {
            get { return this.contactPersonField; }
            set { this.contactPersonField = value; }
        }
    }
}