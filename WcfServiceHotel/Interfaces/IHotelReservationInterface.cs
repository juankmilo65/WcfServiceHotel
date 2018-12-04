using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WcfServiceHotel.Interfaces
{
    public interface IHotelReservationInterface
    {
        [OperationContract]
        string GetXMLInformation();
    }
}
