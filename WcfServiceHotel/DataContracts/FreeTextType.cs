using System.Xml.Serialization;

namespace WcfServiceHotel.DataContracts
{
    public partial class FreeTextType
    {
        private string languageField;
        private string valueField;

        [XmlAttributeAttribute(DataType = "language")]
        public string Language
        {
            get { return this.languageField; }
            set { this.languageField = value; }
        }

        [XmlTextAttribute()]
        public string Value
        {
            get { return this.valueField; }
            set { this.valueField = value; }
        }
    }
}