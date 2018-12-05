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
    public partial class GuestCountTypeGuestCount
    {
        private string ageQualifyingCodeField;
        private string ageField;
        private string countField;
        private string ageBucketField;

        [XmlAttributeAttribute()]
        public string AgeQualifyingCode
        {
            get { return this.ageQualifyingCodeField; }
            set { this.ageQualifyingCodeField = value; }
        }

        [XmlAttributeAttribute(DataType = "integer")]
        public string Age
        {
            get { return this.ageField; }
            set { this.ageField = value; }
        }

        [XmlAttributeAttribute(DataType = "integer")]
        public string Count
        {
            get { return this.countField; }
            set { this.countField = value; }
        }

        [XmlAttributeAttribute()]
        public string AgeBucket
        {
            get { return this.ageBucketField; }
            set { this.ageBucketField = value; }
        }
    }
}