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
    public partial class RoomTypeType
    {
        private FormattedTextTextType[] roomDescriptionField;
        private AdditionalDetailType[] additionalDetailsField;
        private string roomTypeField;
        private string roomTypeCodeField;
        private string roomCategoryField;
        private string roomIDField;
        private bool nonSmokingField;
        private bool nonSmokingFieldSpecified;
        private string configurationField;

        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("Text", IsNullable = false)]
        public FormattedTextTextType[] RoomDescription
        {
            get { return this.roomDescriptionField; }
            set { this.roomDescriptionField = value; }
        }

        [XmlArrayAttribute(Order = 1)]
        [XmlArrayItemAttribute("AdditionalDetail", IsNullable = false)]
        public AdditionalDetailType[] AdditionalDetails
        {
            get { return this.additionalDetailsField; }
            set
            { this.additionalDetailsField = value; }
        }

        [XmlAttributeAttribute()]
        public string RoomType
        {
            get { return this.roomTypeField; }
            set { this.roomTypeField = value; }
        }

        [XmlAttributeAttribute()]
        public string RoomTypeCode
        {
            get { return this.roomTypeCodeField; }
            set { this.roomTypeCodeField = value; }
        }

        [XmlAttributeAttribute()]
        public string RoomCategory
        {
            get { return this.roomCategoryField; }
            set { this.roomCategoryField = value; }
        }

        [XmlAttributeAttribute()]
        public string RoomID
        {
            get { return this.roomIDField; }
            set { this.roomIDField = value; }
        }

        [XmlAttributeAttribute()]
        public bool NonSmoking
        {
            get { return this.nonSmokingField; }
            set { this.nonSmokingField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool NonSmokingSpecified
        {
            get { return this.nonSmokingFieldSpecified; }
            set { this.nonSmokingFieldSpecified = value; }
        }

        [XmlAttributeAttribute()]
        public string Configuration
        {
            get { return this.configurationField; }
            set { this.configurationField = value; }
        }
    }
}