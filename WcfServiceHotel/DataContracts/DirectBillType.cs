using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace WcfServiceHotel.DataContracts
{
    [GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [Serializable()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class DirectBillType
    {
        private string directBill_IDField;

        [XmlAttributeAttribute()]
        public string DirectBill_ID
        {
            get { return this.directBill_IDField; }
            set { this.directBill_IDField = value; }
        }
    }
}