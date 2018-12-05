﻿using System;
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
    public partial class HotelReservationsType
    {

        private HotelReservationsTypeHotelReservation[] hotelReservationField;

        [XmlElementAttribute("HotelReservation", Order = 0)]
        public HotelReservationsTypeHotelReservation[] HotelReservation
        {
            get { return this.hotelReservationField; }
            set { this.hotelReservationField = value; }
        }
    }
}