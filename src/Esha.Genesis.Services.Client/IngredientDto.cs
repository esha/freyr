using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [XmlInclude(typeof(PureFoodDto))]
    [GeneratedCode("svcutil", "4.6.1055.0")]
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