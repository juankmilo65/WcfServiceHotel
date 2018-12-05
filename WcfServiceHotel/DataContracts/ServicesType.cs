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
    [XmlTypeAttribute(Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class ServicesType
    {
        private ServiceType[] serviceField;
        private ServicesTypeServiceCategory[] serviceCategoryField;

        [XmlElementAttribute("Service", Order = 0)]
        public ServiceType[] Service
        {
            get{return this.serviceField;}
            set{this.serviceField = value;}
        }

        [XmlElementAttribute("ServiceCategory", Order = 1)]
        public ServicesTypeServiceCategory[] ServiceCategory
        {
            get{return this.serviceCategoryField;}
            set{this.serviceCategoryField = value;}
        }
    }
}