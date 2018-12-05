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
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class ResGuestTypeProfileInfo
    {
        private UniqueID_Type[] uniqueIDField;
        private RESX_ResGuest__ProfileType profileField;

        [XmlElementAttribute("UniqueID", Order = 0)]
        public UniqueID_Type[] UniqueID
        {
            get { return this.uniqueIDField; }
            set { this.uniqueIDField = value; }
        }

        [XmlElementAttribute(Order = 1)]
        public RESX_ResGuest__ProfileType Profile
        {
            get { return this.profileField; }
            set { this.profileField = value; }
        }
    }
}