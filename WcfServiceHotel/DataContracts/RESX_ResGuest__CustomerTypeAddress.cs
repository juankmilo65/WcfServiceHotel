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
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class RESX_ResGuest__CustomerTypeAddress
    {
        private CompanyNameType companyNameField;
        private PersonNameType addresseeNameField;

        [XmlElementAttribute(Order = 0)]
        public CompanyNameType CompanyName
        {
            get { return this.companyNameField; }
            set { this.companyNameField = value; }
        }

        [XmlElementAttribute(Order = 1)]
        public PersonNameType AddresseeName
        {
            get { return this.addresseeNameField; }
            set { this.addresseeNameField = value; }
        }
    }
}