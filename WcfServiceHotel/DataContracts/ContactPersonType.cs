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
    public partial class ContactPersonType
    {
        private PersonNameType personNameField;
        private ContactPersonTypeTelephone[] telephoneField;
        private AddressInfoType[] addressField;
        private EmailType[] emailField;

        [XmlElementAttribute(Order = 0)]
        public PersonNameType PersonName
        {
            get { return this.personNameField; }
            set { this.personNameField = value; }
        }

        [XmlElementAttribute("Telephone", Order = 1)]
        public ContactPersonTypeTelephone[] Telephone
        {
            get { return this.telephoneField; }
            set { this.telephoneField = value; }
        }

        [XmlElementAttribute("Address", Order = 2)]
        public AddressInfoType[] Address
        {
            get { return this.addressField; }
            set { this.addressField = value; }
        }

        [XmlElementAttribute("Email", Order = 3)]
        public EmailType[] Email
        {
            get { return this.emailField; }
            set { this.emailField = value; }
        }
    }
}