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
    public partial class RoomStayType
    {
        private RoomTypeType[] roomTypesField;
        private RatePlanType[] ratePlansField;
        private RoomStayTypeRoomRate[] roomRatesField;
        private GuestCountTypeGuestCount[] guestCountsField;
        private RoomStayTypeTimeSpan timeSpanField;
        private GuaranteeType[] guaranteeField;
        private RESX_DepositPayments_RequiredPaymentsTypeGuaranteePayment[] depositPaymentsField;
        private DiscountType discountField;
        private TotalType totalField;
        private string marketCodeField;
        private string sourceOfBusinessField;
        private string promotionCodeField;

        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("RoomType", IsNullable = false)]
        public RoomTypeType[] RoomTypes
        {
            get { return this.roomTypesField; }
            set { this.roomTypesField = value; }
        }

        [XmlArrayAttribute(Order = 1)]
        [XmlArrayItemAttribute("RatePlan", IsNullable = false)]
        public RatePlanType[] RatePlans
        {
            get { return this.ratePlansField; }
            set { this.ratePlansField = value; }
        }

        [XmlArrayAttribute(Order = 2)]
        [XmlArrayItemAttribute("RoomRate", IsNullable = false)]
        public RoomStayTypeRoomRate[] RoomRates
        {
            get { return this.roomRatesField; }
            set { this.roomRatesField = value; }
        }

        [XmlArrayAttribute(Order = 3)]
        [XmlArrayItemAttribute("GuestCount", IsNullable = false)]
        public GuestCountTypeGuestCount[] GuestCounts
        {
            get { return this.guestCountsField; }
            set { this.guestCountsField = value; }
        }

        [XmlElementAttribute(Order = 4)]
        public RoomStayTypeTimeSpan TimeSpan
        {
            get { return this.timeSpanField; }
            set { this.timeSpanField = value; }
        }

        [XmlElementAttribute("Guarantee", Order = 5)]
        public GuaranteeType[] Guarantee
        {
            get { return this.guaranteeField; }
            set { this.guaranteeField = value; }
        }

        [XmlArrayAttribute(Order = 6)]
        [XmlArrayItemAttribute("GuaranteePayment", IsNullable = false)]
        public RESX_DepositPayments_RequiredPaymentsTypeGuaranteePayment[] DepositPayments
        {
            get { return this.depositPaymentsField; }
            set { this.depositPaymentsField = value; }
        }

        [XmlElementAttribute(Order = 7)]
        public DiscountType Discount
        {
            get { return this.discountField; }
            set { this.discountField = value; }
        }

        [XmlElementAttribute(Order = 8)]
        public TotalType Total
        {
            get { return this.totalField; }
            set { this.totalField = value; }
        }

        [XmlAttributeAttribute()]
        public string MarketCode
        {
            get { return this.marketCodeField; }
            set { this.marketCodeField = value; }
        }

        [XmlAttributeAttribute()]
        public string SourceOfBusiness
        {
            get { return this.sourceOfBusinessField; }
            set { this.sourceOfBusinessField = value; }
        }

        [XmlAttributeAttribute()]
        public string PromotionCode
        {
            get { return this.promotionCodeField; }
            set { this.promotionCodeField = value; }
        }
    }
}