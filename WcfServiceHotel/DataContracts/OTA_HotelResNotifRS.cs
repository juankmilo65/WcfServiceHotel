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
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class OTA_HotelResNotifRS
    {
        private SourceType[] pOSField;
        private object[] itemsField;
        private decimal versionField;
        private string echoTokenField;
        private DateTime timeStampField;
        private TransactionStatusType resResponseTypeField;
        private bool resResponseTypeFieldSpecified;

        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("Source", IsNullable = false)]
        public SourceType[] POS
        {
            get { return this.pOSField; }
            set { this.pOSField = value; }
        }

        [XmlElementAttribute("Errors", typeof(ErrorsType), Order = 1)]
        [XmlElementAttribute("HotelReservations", typeof(HotelReservationsType), Order = 1)]
        [XmlElementAttribute("Success", typeof(SuccessType), Order = 1)]
        [XmlElementAttribute("Warnings", typeof(WarningsType), Order = 1)]
        public object[] Items
        {
            get { return this.itemsField; }
            set { this.itemsField = value; }
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

        [XmlAttributeAttribute()]
        public TransactionStatusType ResResponseType
        {
            get { return this.resResponseTypeField; }
            set { this.resResponseTypeField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool ResResponseTypeSpecified
        {
            get { return this.resResponseTypeFieldSpecified; }
            set { this.resResponseTypeFieldSpecified = value; }
        }

    }
}