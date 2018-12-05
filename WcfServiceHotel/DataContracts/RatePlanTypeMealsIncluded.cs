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
    public partial class RatePlanTypeMealsIncluded
    {
        private bool mealPlanIndicatorField;
        private bool mealPlanIndicatorFieldSpecified;
        private string[] mealPlanCodesField;

        [XmlAttributeAttribute()]
        public bool MealPlanIndicator
        {
            get { return this.mealPlanIndicatorField; }
            set { this.mealPlanIndicatorField = value; }
        }

        [XmlIgnoreAttribute()]
        public bool MealPlanIndicatorSpecified
        {
            get { return this.mealPlanIndicatorFieldSpecified; }
            set { this.mealPlanIndicatorFieldSpecified = value; }
        }

        [XmlAttributeAttribute()]
        public string[] MealPlanCodes
        {
            get { return this.mealPlanCodesField; }
            set { this.mealPlanCodesField = value; }
        }
    }
}