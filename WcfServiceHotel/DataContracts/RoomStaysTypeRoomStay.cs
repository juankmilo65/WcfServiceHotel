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
    public partial class RoomStaysTypeRoomStay : RoomStayType
    {

        private ResGuestRPHsTypeResGuestRPH[] resGuestRPHsField;
        private MembershipTypeMembership[] membershipsField;
        private CommentTypeComment[] commentsField;
        private SpecialRequestTypeSpecialRequest[] specialRequestsField;
        private ServiceRPHsTypeServiceRPH[] serviceRPHsField;

        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("ResGuestRPH", IsNullable = false)]
        public ResGuestRPHsTypeResGuestRPH[] ResGuestRPHs
        {
            get { return this.resGuestRPHsField; }
            set { this.resGuestRPHsField = value; }
        }

        [XmlArrayAttribute(Order = 1)]
        [XmlArrayItemAttribute("Membership", IsNullable = false)]
        public MembershipTypeMembership[] Memberships
        {
            get { return this.membershipsField; }
            set { this.membershipsField = value; }
        }

        [XmlArrayAttribute(Order = 2)]
        [XmlArrayItemAttribute("Comment", IsNullable = false)]
        public CommentTypeComment[] Comments
        {
            get { return this.commentsField; }
            set { this.commentsField = value; }
        }

        [XmlArrayAttribute(Order = 3)]
        [XmlArrayItemAttribute("SpecialRequest", IsNullable = false)]
        public SpecialRequestTypeSpecialRequest[] SpecialRequests
        {
            get { return this.specialRequestsField; }
            set { this.specialRequestsField = value; }
        }

        [XmlArrayAttribute(Order = 4)]
        [XmlArrayItemAttribute("ServiceRPH", IsNullable = false)]
        public ServiceRPHsTypeServiceRPH[] ServiceRPHs
        {
            get { return this.serviceRPHsField; }
            set { this.serviceRPHsField = value; }
        }
    }
}