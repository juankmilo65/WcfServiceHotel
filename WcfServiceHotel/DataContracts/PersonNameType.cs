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
    public partial class PersonNameType
    {
        private string[] namePrefixField;
        private string[] givenNameField;
        private string[] middleNameField;
        private string surnameField;
        private string[] nameSuffixField;
        private string[] nameTitleField;
        private string nameTypeField;
        private string languageField;

        [XmlElementAttribute("NamePrefix", Order = 0)]
        public string[] NamePrefix
        {
            get { return this.namePrefixField; }
            set { this.namePrefixField = value; }
        }

        [XmlElementAttribute("GivenName", Order = 1)]
        public string[] GivenName
        {
            get { return this.givenNameField; }
            set { this.givenNameField = value; }
        }

        [XmlElementAttribute("MiddleName", Order = 2)]
        public string[] MiddleName
        {
            get { return this.middleNameField; }
            set { this.middleNameField = value; }
        }

        [XmlElementAttribute(Order = 3)]
        public string Surname
        {
            get { return this.surnameField; }
            set { this.surnameField = value; }
        }

        [XmlElementAttribute("NameSuffix", Order = 4)]
        public string[] NameSuffix
        {
            get { return this.nameSuffixField; }
            set { this.nameSuffixField = value; }
        }

        [XmlElementAttribute("NameTitle", Order = 5)]
        public string[] NameTitle
        {
            get { return this.nameTitleField; }
            set { this.nameTitleField = value; }
        }

        [XmlAttributeAttribute()]
        public string NameType
        {
            get { return this.nameTypeField; }
            set { this.nameTypeField = value; }
        }

        [XmlAttributeAttribute(DataType = "language")]
        public string Language
        {
            get { return this.languageField; }
            set { this.languageField = value; }
        }
    }
}