using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [GeneratedCode("svcutil", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class SupplementIngredientDto : FoodDto
    {
        private String _concentrationField;

        private Guid? _ingredientSourceIdField;

        private String _latinNameField;

        private Int32? _shelfLifeDaysField;

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Guid? IngredientSourceId
        {
            get => _ingredientSourceIdField;
            set => _ingredientSourceIdField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Int32? ShelfLifeDays
        {
            get => _shelfLifeDaysField;
            set => _shelfLifeDaysField = value;
        }

        /// <remarks />
        [XmlElement]
        public String LatinName
        {
            get => _latinNameField;
            set => _latinNameField = value;
        }

        /// <remarks />
        [XmlElement]
        public String Concentration
        {
            get => _concentrationField;
            set => _concentrationField = value;
        }
    }
}