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
    public partial class RESX_ResGuest__ProfileType
    {
        private RESX_ResGuest__CustomerType customerField;
        private CompanyInfoType companyInfoField;
        private bool shareAllMarketIndField;
        private bool shareAllMarketIndFieldSpecified;
        private bool shareAllOptOutIndField;
        private bool shareAllOptOutIndFieldSpecified;
        private string profileTypeField;

        [XmlElementAttribute(Order = 0)]
        public RESX_ResGuest__CustomerType Customer
        {
            get { return this.customerField; }
            set { this.customerField = value; }
        }

        [XmlElementAttribute(Order = 1)]
        public CompanyInfoType CompanyInfo
        {
            get { return this.companyInfoField; }
            set { this.companyInfoField = value; }
        }

        [XmlAttributeAttribute()]
        public bool ShareAllMarketInd
        {
            get { return this.shareAllMarketIndField; }
            set { this.shareAllMarketIndField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool ShareAllMarketIndSpecified
        {
            get { return this.shareAllMarketIndFieldSpecified; }
            set { this.shareAllMarketIndFieldSpecified = value; }
        }

        [XmlAttributeAttribute()]
        public bool ShareAllOptOutInd
        {
            get { return this.shareAllOptOutIndField; }
            set { this.shareAllOptOutIndField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool ShareAllOptOutIndSpecified
        {
            get { return this.shareAllOptOutIndFieldSpecified; }
            set { this.shareAllOptOutIndFieldSpecified = value; }
        }

        [XmlAttributeAttribute()]
        public string ProfileType
        {
            get { return this.profileTypeField; }
            set { this.profileTypeField = value; }
        }
    }
}