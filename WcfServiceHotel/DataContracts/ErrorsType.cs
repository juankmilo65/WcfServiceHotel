using System.Xml.Serialization;

namespace WcfServiceHotel.DataContracts
{
    public partial class ErrorsType
    {
        private ErrorType[] errorField;


        [XmlElementAttribute("Error", Order = 0)]
        public ErrorType[] Error
        {
            get { return this.errorField; }
            set { this.errorField = value; }
        }
    }
}