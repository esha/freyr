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
    public class RecipeDto : FoodDto
    {
        private Guid? _contentClaimReferenceIdField;

        private String _cookMethodField;

        private String _cookTemperatureField;

        private String _cookTimeField;

        private ConversionDto _definedServingWeightConversionField;

        private Int32? _haccpHeadingLevelField;

        private Guid[] _haccpIdsField;

        private String _instructionsField;

        private GlobalString[] _nutrientContentClaimsTextField;

        private String _panSizeField;

        private String _preparationTimeField;

        /// <remarks />
        [XmlElement]
        public String PanSize
        {
            get => _panSizeField;
            set => _panSizeField = value;
        }

        /// <remarks />
        [XmlElement]
        public String PreparationTime
        {
            get => _preparationTimeField;
            set => _preparationTimeField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Guid? ContentClaimReferenceId
        {
            get => _contentClaimReferenceIdField;
            set => _contentClaimReferenceIdField = value;
        }

        /// <remarks />
        [XmlElement]
        public String CookMethod
        {
            get => _cookMethodField;
            set => _cookMethodField = value;
        }

        /// <remarks />
        [XmlElement]
        public String CookTemperature
        {
            get => _cookTemperatureField;
            set => _cookTemperatureField = value;
        }

        /// <remarks />
        [XmlElement]
        public String CookTime
        {
            get => _cookTimeField;
            set => _cookTimeField = value;
        }

        /// <remarks />
        [XmlElement]
        public ConversionDto DefinedServingWeightConversion
        {
            get => _definedServingWeightConversionField;
            set => _definedServingWeightConversionField = value;
        }

        /// <remarks />
        [XmlElement]
        public String Instructions
        {
            get => _instructionsField;
            set => _instructionsField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Int32? HaccpHeadingLevel
        {
            get => _haccpHeadingLevelField;
            set => _haccpHeadingLevelField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Id", IsNullable = false)]
        public Guid[] HaccpIds
        {
            get => _haccpIdsField;
            set => _haccpIdsField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] NutrientContentClaimsText
        {
            get => _nutrientContentClaimsTextField;
            set => _nutrientContentClaimsTextField = value;
        }
    }
}