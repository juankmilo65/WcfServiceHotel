using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cliente.HotelReservationReference;
using WcfServiceHotel.DataContracts;

namespace Cliente
{
    class Program
    {
        static void Main(string[] args)
        {
            Byte[] bytes = File.ReadAllBytes(@"D:\Trabajo\webservice chile\MinimunXML.xml");
            String file = Convert.ToBase64String(bytes);
            OTA_HotelResNotifRS response = new OTA_HotelResNotifRS();
            OTA_HotelResNotifRQ request = new OTA_HotelResNotifRQ();

            using (HotelReservationReference.HotelReservationInterfaceClient client = new HotelReservationReference.HotelReservationInterfaceClient())
            {
                response = client.GetXMLInformation(request);
                var echo = response.EchoToken;
            }
        }
    }
}
