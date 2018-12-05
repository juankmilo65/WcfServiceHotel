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
    public partial class BasicPropertyInfoType
    {
        private string chainCodeField;
        private string brandCodeField;
        private string hotelCodeField;
        private string hotelNameField;

        [XmlAttributeAttribute()]
        public string ChainCode
        {
            get { return this.chainCodeField; }
            set { this.chainCodeField = value; }
        }

        [XmlAttributeAttribute()]
        public string BrandCode
        {
            get { return this.brandCodeField; }
            set { this.brandCodeField = value; }
        }

        [XmlAttributeAttribute()]
        public string HotelCode
        {
            get { return this.hotelCodeField; }
            set { this.hotelCodeField = value; }
        }

        [XmlAttributeAttribute()]
        public string HotelName
        {
            get { return this.hotelNameField; }
            set { this.hotelNameField = value; }
        }
    }
}