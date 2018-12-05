using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using WcfServiceHotel.Utilities;

namespace WcfServiceHotel.DataContracts
{
    [GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelReservationType
    {

        private SourceType[] pOSField;
        private RESX_HotelReservationType__UniqueID_Type uniqueIDField;
        private RoomStaysTypeRoomStay[] roomStaysField;
        private ServicesType servicesField;
        private HotelReservationTypeBillingInstructionCode[] billingInstructionCodeField;
        private ResGuestType[] resGuestsField;
        private HotelReservationTypeResGlobalInfo resGlobalInfoField;
        private HotelResStatusType resStatusField;
        private System.DateTime createDateTimeField;
        private bool createDateTimeFieldSpecified;
        private string creatorIDField;
        private System.DateTime lastModifyDateTimeField;
        private bool lastModifyDateTimeFieldSpecified;
        private string lastModifierIDField;

        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("Source", IsNullable = false)]
        public SourceType[] POS
        {
            get { return this.pOSField; }
            set { this.pOSField = value; }
        }

        [System.Xml.Serialization.XmlElementAttribute(Order = 1)]
        public RESX_HotelReservationType__UniqueID_Type UniqueID
        {
            get { return this.uniqueIDField; }
            set { this.uniqueIDField = value; }
        }

        [XmlArrayAttribute(Order = 2)]
        [XmlArrayItemAttribute("RoomStay", IsNullable = false)]
        public RoomStaysTypeRoomStay[] RoomStays
        {
            get { return this.roomStaysField; }
            set { this.roomStaysField = value; }
        }

        [XmlElementAttribute(Order = 3)]
        public ServicesType Services
        {
            get { return this.servicesField; }
            set { this.servicesField = value; }
        }

        [XmlElementAttribute("BillingInstructionCode", Order = 4)]
        public HotelReservationTypeBillingInstructionCode[] BillingInstructionCode
        {
            get { return this.billingInstructionCodeField; }
            set { this.billingInstructionCodeField = value; }
        }

        [XmlArrayAttribute(Order = 5)]
        [XmlArrayItemAttribute("ResGuest", IsNullable = false)]
        public ResGuestType[] ResGuests
        {
            get { return this.resGuestsField; }
            set { this.resGuestsField = value; }
        }

        [XmlElementAttribute(Order = 6)]
        public HotelReservationTypeResGlobalInfo ResGlobalInfo
        {
            get { return this.resGlobalInfoField; }
            set { this.resGlobalInfoField = value; }
        }

        [XmlAttributeAttribute()]
        public HotelResStatusType ResStatus
        {
            get { return this.resStatusField; }
            set { this.resStatusField = value; }
        }

        [XmlAttributeAttribute()]
        public System.DateTime CreateDateTime
        {
            get { return this.createDateTimeField; }
            set { this.createDateTimeField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool CreateDateTimeSpecified
        {
            get { return this.createDateTimeFieldSpecified; }
            set { this.createDateTimeFieldSpecified = value; }
        }

        [XmlAttributeAttribute()]
        public string CreatorID
        {
            get { return this.creatorIDField; }
            set { this.creatorIDField = value; }
        }

        [XmlAttributeAttribute()]
        public System.DateTime LastModifyDateTime
        {
            get { return this.lastModifyDateTimeField; }
            set { this.lastModifyDateTimeField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool LastModifyDateTimeSpecified
        {
            get { return this.lastModifyDateTimeFieldSpecified; }
            set { this.lastModifyDateTimeFieldSpecified = value; }
        }

        [XmlAttributeAttribute()]
        public string LastModifierID
        {
            get { return this.lastModifierIDField; }
            set { this.lastModifierIDField = value; }
        }
    }
}