using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.ServiceModel.Web;
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
        public object GetXMLInformation(string request)
        {
            ResponseXml response = new ResponseXml();

            if (string.IsNullOrEmpty(request))
            {
                return new WebFaultException(HttpStatusCode.BadRequest);
            }

            //SetResponseHttpStatus(HttpStatusCode.OK);
            response.Code = HttpStatusCode.OK.ToString();
            return response;
        }

        public void SetResponseHttpStatus(HttpStatusCode statusCode)
        {
            var context = WebOperationContext.Current;
            context.OutgoingResponse.StatusCode = statusCode;
        }
    }
}
