using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace WcfServiceHotel.DataContracts
{
    [GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategory("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class MembershipTypeMembership
    {
        private string programCodeField;
        private string accountIDField;

        [XmlAttributeAttribute()]
        public string ProgramCode
        {
            get { return this.programCodeField; }
            set { this.programCodeField = value; }
        }

        [XmlAttributeAttribute()]
        public string AccountID
        {
            get { return this.accountIDField; }
            set { this.accountIDField = value; }
        }
    }
}