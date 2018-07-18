using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class PureFoodDto : IngredientDto
    {
        private NutrientDto _baseNutrientField;

        /// <remarks />
        [XmlElement]
        public NutrientDto BaseNutrient
        {
            get => _baseNutrientField;
            set => _baseNutrientField = value;
        }
    }
}