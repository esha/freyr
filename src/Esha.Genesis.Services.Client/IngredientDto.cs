using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [XmlInclude(typeof(PureFoodDto))]
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class IngredientDto : FoodDto
    {
        private Guid? _nutrientProfileIdField;

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Guid? NutrientProfileId
        {
            get => _nutrientProfileIdField;
            set => _nutrientProfileIdField = value;
        }
    }
}