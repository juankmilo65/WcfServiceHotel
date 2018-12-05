using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Xml.Serialization;

namespace WcfServiceHotel.DataContracts
{
    [GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class CommentTypeComment : ParagraphType
    {
        private bool guestViewableField;
        private bool guestViewableFieldSpecified;

        [XmlAttributeAttribute()]
        public bool GuestViewable
        {
            get { return this.guestViewableField; }
            set { this.guestViewableField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool GuestViewableSpecified
        {
            get { return this.guestViewableFieldSpecified; }
            set { this.guestViewableFieldSpecified = value; }
        }
    }
}