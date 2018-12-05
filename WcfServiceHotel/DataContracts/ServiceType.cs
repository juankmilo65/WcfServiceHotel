using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;
using WcfServiceHotel.Utilities;

namespace WcfServiceHotel.DataContracts
{
    [GeneratedCodeAttribute("svcutil", "3.0.4506.2152")]
    [SerializableAttribute()]
    [DebuggerStepThroughAttribute()]
    [DesignerCategoryAttribute("code")]
    [XmlTypeAttribute(Namespace = "http://www.opentravel.org/OTA/2003/05")]
    public partial class ServiceType
    {
        private ServiceTypePrice[] priceField;
        private ServiceTypeServiceDetails serviceDetailsField;
        private PricingType servicePricingTypeField;
        private bool servicePricingTypeFieldSpecified;
        private string serviceInventoryCodeField;
        private bool inclusiveField;
        private bool inclusiveFieldSpecified;
        private string quantityField;
        private string serviceRPHField;
        private string typeField;
        private string idField;
        private string iD_ContextField;
        private string serviceCategoryCodeField;

        [XmlElementAttribute("Price", Order = 0)]
        public ServiceTypePrice[] Price
        {
            get { return this.priceField; }
            set { this.priceField = value; }
        }

        [XmlElementAttribute(Order = 1)]
        public ServiceTypeServiceDetails ServiceDetails
        {
            get { return this.serviceDetailsField; }
            set { this.serviceDetailsField = value; }
        }

        [XmlAttributeAttribute()]
        public PricingType ServicePricingType
        {
            get { return this.servicePricingTypeField; }
            set { this.servicePricingTypeField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool ServicePricingTypeSpecified
        {
            get { return this.servicePricingTypeFieldSpecified; }
            set { this.servicePricingTypeFieldSpecified = value; }
        }

        [XmlAttributeAttribute()]
        public string ServiceInventoryCode
        {
            get { return this.serviceInventoryCodeField; }
            set { this.serviceInventoryCodeField = value; }
        }

        [XmlAttributeAttribute()]
        public bool Inclusive
        {
            get { return this.inclusiveField; }
            set { this.inclusiveField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool InclusiveSpecified
        {
            get { return this.inclusiveFieldSpecified; }
            set { this.inclusiveFieldSpecified = value; }
        }

        [XmlAttributeAttribute(DataType = "integer")]
        public string Quantity
        {
            get { return this.quantityField; }
            set { this.quantityField = value; }
        }

        [XmlAttributeAttribute()]
        public string ServiceRPH
        {
            get { return this.serviceRPHField; }
            set { this.serviceRPHField = value; }
        }

        [XmlAttributeAttribute()]
        public string Type
        {
            get { return this.typeField; }
            set { this.typeField = value; }
        }

        [XmlAttributeAttribute()]
        public string ID
        {
            get { return this.idField; }
            set { this.idField = value; }
        }

        [XmlAttributeAttribute()]
        public string ID_Context
        {
            get { return this.iD_ContextField; }
            set { this.iD_ContextField = value; }
        }

        [XmlAttributeAttribute()]
        public string ServiceCategoryCode
        {
            get { return this.serviceCategoryCodeField; }
            set { this.serviceCategoryCodeField = value; }
        }
    }
}