using System.ServiceModel;

namespace WcfServiceHotel.Interfaces
{
    public interface IHotelReservationInterface
    {
        [OperationContract]
        string GetXMLInformation();
    }
}
