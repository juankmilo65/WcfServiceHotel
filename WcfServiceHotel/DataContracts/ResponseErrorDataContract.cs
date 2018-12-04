using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;
using WcfServiceHotel.Dtos;

namespace WcfServiceHotel.DataContracts
{
    [DataContract]
    public class ResponseErrorDataContract
    {
        List<ErrorDto> errorValue = new List<ErrorDto>();

        [DataMember]
        public List<ErrorDto> Errors
        {
            get { return errorValue; }
            set { errorValue = value; }
        }
    }
}