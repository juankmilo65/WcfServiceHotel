using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;
using WcfServiceHotel.DataContracts;
using WcfServiceHotel.Dtos;
using WcfServiceHotel.Interfaces;

namespace WcfServiceHotel.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class HotelReservationService : IHotelReservationInterface
    {
        public OTA_HotelResNotifRS GetXMLInformation(OTA_HotelResNotifRQ request)
        {
            return new OTA_HotelResNotifRS() { };
        }
    }
}
