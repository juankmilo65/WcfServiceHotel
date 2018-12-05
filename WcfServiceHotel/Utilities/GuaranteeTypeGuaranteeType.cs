using System.Xml.Serialization;

namespace WcfServiceHotel.Utilities
{
    public enum GuaranteeTypeGuaranteeType
    {
        GuaranteeRequired,
        None,
        [XmlEnumAttribute("CC/DC/Voucher")]
        CCDCVoucher,
        Profile,
        Deposit,
        PrePay,
        DepositRequired,
    }
}