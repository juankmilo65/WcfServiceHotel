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
    public partial class ResGuestType
    {
        private ResGuestTypeProfileInfo[] profilesField;
        private SpecialRequestTypeSpecialRequest[] specialRequestsField;
        private CommentTypeComment[] commentsField;
        private ServiceRPHsTypeServiceRPH[] serviceRPHsField;
        private TransportInfoTypeTransportInfo[] arrivalTransportField;
        private TransportInfoTypeTransportInfo[] departureTransportField;
        private string resGuestRPHField;
        private string ageQualifyingCodeField;
        private System.DateTime arrivalTimeField;
        private bool arrivalTimeFieldSpecified;
        private bool primaryIndicatorField;
        private bool primaryIndicatorFieldSpecified;
        private string ageField;

        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("ProfileInfo", IsNullable = false)]
        public ResGuestTypeProfileInfo[] Profiles
        {
            get { return this.profilesField; }
            set { this.profilesField = value; }
        }

        [XmlArrayAttribute(Order = 1)]
        [XmlArrayItemAttribute("SpecialRequest", IsNullable = false)]
        public SpecialRequestTypeSpecialRequest[] SpecialRequests
        {
            get { return this.specialRequestsField; }
            set { this.specialRequestsField = value; }
        }

        [XmlArrayAttribute(Order = 2)]
        [XmlArrayItemAttribute("Comment", IsNullable = false)]
        public CommentTypeComment[] Comments
        {
            get { return this.commentsField; }
            set { this.commentsField = value; }
        }

        [XmlArrayAttribute(Order = 3)]
        [XmlArrayItemAttribute("ServiceRPH", IsNullable = false)]
        public ServiceRPHsTypeServiceRPH[] ServiceRPHs
        {
            get { return this.serviceRPHsField; }
            set { this.serviceRPHsField = value; }
        }

        [XmlArrayAttribute(Order = 4)]
        [XmlArrayItemAttribute("TransportInfo", IsNullable = false)]
        public TransportInfoTypeTransportInfo[] ArrivalTransport
        {
            get { return this.arrivalTransportField; }
            set { this.arrivalTransportField = value; }
        }

        [XmlArrayAttribute(Order = 5)]
        [XmlArrayItemAttribute("TransportInfo", IsNullable = false)]
        public TransportInfoTypeTransportInfo[] DepartureTransport
        {
            get { return this.departureTransportField; }
            set { this.departureTransportField = value; }
        }

        [XmlAttributeAttribute()]
        public string ResGuestRPH
        {
            get { return this.resGuestRPHField; }
            set { this.resGuestRPHField = value; }
        }

        [XmlAttributeAttribute()]
        public string AgeQualifyingCode
        {
            get { return this.ageQualifyingCodeField; }
            set { this.ageQualifyingCodeField = value; }
        }

        [XmlAttributeAttribute(DataType = "time")]
        public System.DateTime ArrivalTime
        {
            get { return this.arrivalTimeField; }
            set { this.arrivalTimeField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool ArrivalTimeSpecified
        {
            get { return this.arrivalTimeFieldSpecified; }
            set { this.arrivalTimeFieldSpecified = value; }
        }

        [XmlAttributeAttribute()]
        public bool PrimaryIndicator
        {
            get { return this.primaryIndicatorField; }
            set { this.primaryIndicatorField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool PrimaryIndicatorSpecified
        {
            get { return this.primaryIndicatorFieldSpecified; }
            set { this.primaryIndicatorFieldSpecified = value; }
        }

        [XmlAttributeAttribute(DataType = "integer")]
        public string Age
        {
            get { return this.ageField; }
            set { this.ageField = value; }
        }
    }
}