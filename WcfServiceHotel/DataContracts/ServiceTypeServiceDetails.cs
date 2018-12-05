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
    public partial class ServiceTypeServiceDetails
    {
        private GuestCountTypeGuestCount[] guestCountsField;
        private ServiceTypeServiceDetailsTimeSpan timeSpanField;
        private CommentTypeComment[] commentsField;
        private FormattedTextTextType[] serviceDescriptionField;

        [XmlArrayAttribute(Order = 0)]
        [XmlArrayItemAttribute("GuestCount", IsNullable = false)]
        public GuestCountTypeGuestCount[] GuestCounts
        {
            get { return this.guestCountsField; }
            set { this.guestCountsField = value; }
        }

        [XmlElementAttribute(Order = 1)]
        public ServiceTypeServiceDetailsTimeSpan TimeSpan
        {
            get { return this.timeSpanField; }
            set { this.timeSpanField = value; }
        }

        [XmlArrayAttribute(Order = 2)]
        [XmlArrayItemAttribute("Comment", IsNullable = false)]
        public CommentTypeComment[] Comments
        {
            get { return this.commentsField; }
            set { this.commentsField = value; }
        }

        [XmlArrayAttribute(Order = 3)]
        [XmlArrayItemAttribute("Text", IsNullable = false)]
        public FormattedTextTextType[] ServiceDescription
        {
            get { return this.serviceDescriptionField; }
            set { this.serviceDescriptionField = value; }
        }
    }
}