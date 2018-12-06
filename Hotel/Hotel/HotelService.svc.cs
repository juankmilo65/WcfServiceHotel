using Hotel.DataContracts;
using Hotel.Utilities;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace Hotel
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class HotelService : IHotelService
    {
        public Response ValidationXML(string value)
        {
            ValidationsXml validation = new ValidationsXml();
            Response response = new Response();

            response = validation.XmlProcessor(value);

            return response;
        }

        private void SetResponseHttpStatus(HttpStatusCode statusCode)
        {
            var context = WebOperationContext.Current;
            context.OutgoingResponse.StatusCode = statusCode;
        }
    }
}
