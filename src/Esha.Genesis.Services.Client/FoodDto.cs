using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [XmlInclude(typeof(IngredientDto))]
    [XmlInclude(typeof(PureFoodDto))]
    [XmlInclude(typeof(SupplementIngredientDto))]
    [XmlInclude(typeof(SupplementFormulaDto))]
    [XmlInclude(typeof(RecipeDto))]
    [XmlInclude(typeof(MealDto))]
    [XmlInclude(typeof(IntakeDto))]
    [XmlInclude(typeof(DietRecallDto))]
    [GeneratedCode("svcutil", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public abstract class FoodDto : EshaDto
    {
        private AllergenStatementSettingsDto[] _allergenStatementSettingsField;

        private AllergenStatementDto[] _allergenStatementsField;

        private String[] _alternateNamesField;

        private AmountCostDto _amountCostField;

        private AnalysisDto[] _analysesField;

        private AnalysisOverrideDto _analysisOverridesField;

        private BrandDto _brandField;

        private GlobalString[] _commonNameField;

        private Guid? _conversionMapIdField;

        private ConversionDto[] _conversionsField;

        private XmlDateTimeOffset _createdField;

        private Guid? _defaultWeightUnitIdField;

        private AmountDto _definingAmountField;

        private GlobalString[] _descriptionField;

        private Int32? _eshaCodeField;

        private QuantityDto _glycemicIndexField;

        private Guid[] _groupsField;

        private ImageModelDto[] _imagesField;

        private IngredientStatementSettingsDto[] _ingredientStatementSettingsField;

        private IngredientStatementDto[] _ingredientStatementsField;

        private FoodItemDto[] _itemsField;

        private Guid[] _labelsField;

        private Int32? _legacyKeyField;

        private Int32? _legacyNutrientRefNumField;

        private Int32? _legacyYieldKeyField;

        private XmlDateTimeOffset _modifiedField;

        private GlobalString[] _nameField;

        private String _notesField;

        private Guid[] _nutrientTransformsField;

        private String _ownerNameField;

        private XmlElement _propertyValuesField;

        private Int32? _usdaCodeField;

        private String _userCodeField;

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("AllergenStatement")]
        public AllergenStatementDto[] AllergenStatements
        {
            get => _allergenStatementsField;
            set => _allergenStatementsField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("AllergenStatementSetting")]
        public AllergenStatementSettingsDto[] AllergenStatementSettings
        {
            get => _allergenStatementSettingsField;
            set => _allergenStatementSettingsField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Name")]
        public String[] AlternateNames
        {
            get => _alternateNamesField;
            set => _alternateNamesField = value;
        }

        /// <remarks />
        [XmlElement]
        public String Notes
        {
            get => _notesField;
            set => _notesField = value;
        }

        /// <remarks />
        [XmlElement]
        public AmountDto DefiningAmount
        {
            get => _definingAmountField;
            set => _definingAmountField = value;
        }

        /// <remarks />
        [XmlElement]
        public AmountCostDto AmountCost
        {
            get => _amountCostField;
            set => _amountCostField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Analysis")]
        public AnalysisDto[] Analyses
        {
            get => _analysesField;
            set => _analysesField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Int32? EshaCode
        {
            get => _eshaCodeField;
            set => _eshaCodeField = value;
        }

        /// <remarks />
        [XmlElement]
        public String OwnerName
        {
            get => _ownerNameField;
            set => _ownerNameField = value;
        }

        /// <remarks />
        [XmlElement]
        public BrandDto Brand
        {
            get => _brandField;
            set => _brandField = value;
        }

        /// <remarks />
        [XmlElement]
        public AnalysisOverrideDto AnalysisOverrides
        {
            get => _analysisOverridesField;
            set => _analysisOverridesField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] CommonName
        {
            get => _commonNameField;
            set => _commonNameField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Guid? DefaultWeightUnitId
        {
            get => _defaultWeightUnitIdField;
            set => _defaultWeightUnitIdField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Guid? ConversionMapId
        {
            get => _conversionMapIdField;
            set => _conversionMapIdField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Conversion")]
        public ConversionDto[] Conversions
        {
            get => _conversionsField;
            set => _conversionsField = value;
        }

        /// <remarks />
        [XmlElement]
        public QuantityDto GlycemicIndex
        {
            get => _glycemicIndexField;
            set => _glycemicIndexField = value;
        }

        /// <remarks />
        [XmlElement]
        public XmlDateTimeOffset Created
        {
            get => _createdField;
            set => _createdField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] Description
        {
            get => _descriptionField;
            set => _descriptionField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Int32? LegacyYieldKey
        {
            get => _legacyYieldKeyField;
            set => _legacyYieldKeyField = value;
        }

        /// <remarks />
        [XmlElement]
        public String UserCode
        {
            get => _userCodeField;
            set => _userCodeField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Int32? UsdaCode
        {
            get => _usdaCodeField;
            set => _usdaCodeField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Id", IsNullable = false)]
        public Guid[] Groups
        {
            get => _groupsField;
            set => _groupsField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Image")]
        public ImageModelDto[] Images
        {
            get => _imagesField;
            set => _imagesField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("IngredientStatement")]
        public IngredientStatementDto[] IngredientStatements
        {
            get => _ingredientStatementsField;
            set => _ingredientStatementsField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("IngredientStatementSetting")]
        public IngredientStatementSettingsDto[] IngredientStatementSettings
        {
            get => _ingredientStatementSettingsField;
            set => _ingredientStatementSettingsField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("FoodItem")]
        [XmlArrayItem("PureFoodItem", typeof(PureFoodItemDto))]
        [XmlArrayItem("SupplementFormulaFoodItem", typeof(SupplementFormulaFoodItemDto))]
        public FoodItemDto[] Items
        {
            get => _itemsField;
            set => _itemsField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Id", IsNullable = false)]
        public Guid[] Labels
        {
            get => _labelsField;
            set => _labelsField = value;
        }

        /// <remarks />
        [XmlElement]
        public XmlDateTimeOffset Modified
        {
            get => _modifiedField;
            set => _modifiedField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Int32? LegacyKey
        {
            get => _legacyKeyField;
            set => _legacyKeyField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Int32? LegacyNutrientRefNum
        {
            get => _legacyNutrientRefNumField;
            set => _legacyNutrientRefNumField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Id", IsNullable = false)]
        public Guid[] NutrientTransforms
        {
            get => _nutrientTransformsField;
            set => _nutrientTransformsField = value;
        }

        /// <remarks />
        [XmlElement]
        public XmlElement PropertyValues
        {
            get => _propertyValuesField;
            set => _propertyValuesField = value;
        }
    }
}