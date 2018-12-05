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
    [XmlIncludeAttribute(typeof(AddressInfoType))]
    [GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public class AddressType
    {
        private string[] addressLineField;
        private string cityNameField;
        private string postalCodeField;
        private StateProvType stateProvField;
        private CountryNameType countryNameField;
        private string typeField;

        [XmlElementAttribute("AddressLine", Order = 0)]
        public string[] AddressLine
        {
            get{return this.addressLineField;}
            set{this.addressLineField = value;}
        }

        [XmlElementAttribute(Order = 1)]
        public string CityName
        {
            get{return this.cityNameField;}
            set {this.cityNameField = value;   }
        }

        [XmlElementAttribute(Order = 2)]
        public string PostalCode
        {
            get{return this.postalCodeField;}
            set{this.postalCodeField = value;}
        }

        [XmlElementAttribute(Order = 3)]
        public StateProvType StateProv
        {
            get { return this.stateProvField; }
            set { this.stateProvField = value; }
        }

        [XmlElementAttribute(Order = 4)]
        public CountryNameType CountryName
        {
            get { return this.countryNameField; }
            set { this.countryNameField = value; }
        }

        [XmlAttributeAttribute()]
        public string Type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }
    }
}