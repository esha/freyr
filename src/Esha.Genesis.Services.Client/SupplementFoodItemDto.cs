using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [XmlInclude(typeof(PureFoodItemDto))]
    [XmlInclude(typeof(SupplementFormulaFoodItemDto))]
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class SupplementFoodItemDto : FoodItemDto
    {
        private Bioactivity _bioactivityField;

        /// <remarks />
        [XmlElement]
        public Bioactivity Bioactivity
        {
            get => _bioactivityField;
            set => _bioactivityField = value;
        }
    }
}