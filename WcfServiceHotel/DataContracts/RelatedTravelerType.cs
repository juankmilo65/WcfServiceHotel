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
    public partial class RelatedTravelerType
    {
        private UniqueID_Type uniqueIDField;
        private PersonNameType personNameField;
        private string relationField;
        private System.DateTime birthDateField;
        private bool birthDateFieldSpecified;

        [XmlElementAttribute(Order = 0)]
        public UniqueID_Type UniqueID
        {
            get { return this.uniqueIDField; }
            set { this.uniqueIDField = value; }
        }

        [XmlElementAttribute(Order = 1)]
        public PersonNameType PersonName
        {
            get { return this.personNameField; }
            set { this.personNameField = value; }
        }

        [XmlAttributeAttribute()]
        public string Relation
        {
            get { return this.relationField; }
            set { this.relationField = value; }
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
    }
}