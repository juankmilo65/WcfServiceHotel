using System.Xml.Serialization;

namespace WcfServiceHotel.Utilities
{
    public enum TransactionStatusType
    {
        Pending,
        Cancelled,
        Modified,
        Committed,
        Ignored,
        [XmlEnumAttribute("On Hold")]
        OnHold,
        Unsuccessful,
        PendingCancellation,
        PendingPurchase,
        Requested,
        Reserved,
        Unchanged,
        RequestDenied,
        Ticketed,
    }
}