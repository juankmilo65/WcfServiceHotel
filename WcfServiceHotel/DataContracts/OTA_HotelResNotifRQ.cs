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
    public class OTA_HotelResNotifRQ
    {
        private HotelReservationsTypeHotelReservation[] hotelReservationsField;
        private decimal versionField;
        private string echoTokenField;
        private System.DateTime timeStampField;

        [System.Xml.Serialization.XmlArrayAttribute(Order = 0)]
        [System.Xml.Serialization.XmlArrayItemAttribute("HotelReservation", IsNullable = false)]
        public HotelReservationsTypeHotelReservation[] HotelReservations
        {
            get{return this.hotelReservationsField;}
            set{this.hotelReservationsField = value;}
        }

        [XmlAttributeAttribute()]
        public decimal Version
        {
            get { return this.versionField; }
            set { this.versionField = value; }
        }

        [XmlAttributeAttribute()]
        public string EchoToken
        {
            get { return this.echoTokenField; }
            set { this.echoTokenField = value; }
        }

        [XmlAttributeAttribute()]
        public System.DateTime TimeStamp
        {
            get { return this.timeStampField; }
            set { this.timeStampField = value; }
        }
    }
}