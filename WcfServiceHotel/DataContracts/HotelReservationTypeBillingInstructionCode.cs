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
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class HotelReservationTypeBillingInstructionCode
    {
        private HotelReservationTypeBillingInstructionCodeResGuestRPH[] resGuestRPHField;
        private string billingCodeField;
        private string accountNumberField;
        private string startField;
        private string endField;
        private string authorizationCodeField;
        private string descriptionField;

        
        [XmlElementAttribute("ResGuestRPH", Order = 0)]
        public HotelReservationTypeBillingInstructionCodeResGuestRPH[] ResGuestRPH
        {
            get{return this.resGuestRPHField;}
            set
            {this.resGuestRPHField = value;}
        }

       
        [XmlAttributeAttribute()]
        public string BillingCode
        {
            get{return this.billingCodeField;}
            set{this.billingCodeField = value;}
        }

        [XmlAttributeAttribute()]
        public string AccountNumber
        {
            get{return this.accountNumberField;}
            set{this.accountNumberField = value;}
        }

        [XmlAttributeAttribute()]
        public string Start
        {
            get{return this.startField;}
            set{this.startField = value;}
        }

        [XmlAttributeAttribute()]
        public string End
        {
            get{return this.endField;}
            set{this.endField = value;}
        }

        [XmlAttributeAttribute()]
        public string AuthorizationCode
        {
            get{return this.authorizationCodeField;}
            set{ this.authorizationCodeField = value;}
        }

        [XmlAttributeAttribute()]
        public string Description
        {
            get{return this.descriptionField;}
            set{this.descriptionField = value;}
        }
    }
}