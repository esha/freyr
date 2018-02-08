using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [XmlInclude(typeof(ConditionDto))]
    [XmlInclude(typeof(LabelSettingsDto))]
    [XmlInclude(typeof(NutrientDto))]
    [XmlInclude(typeof(UnitDto))]
    [XmlInclude(typeof(FoodDto))]
    [XmlInclude(typeof(IngredientDto))]
    [XmlInclude(typeof(PureFoodDto))]
    [XmlInclude(typeof(SupplementIngredientDto))]
    [XmlInclude(typeof(SupplementFormulaDto))]
    [XmlInclude(typeof(RecipeDto))]
    [XmlInclude(typeof(MealDto))]
    [XmlInclude(typeof(IntakeDto))]
    [XmlInclude(typeof(DietRecallDto))]
    [XmlInclude(typeof(AnalysisDto))]
    [XmlInclude(typeof(ItemAnalysisDto))]
    [XmlInclude(typeof(StatementSettingsBaseDto))]
    [XmlInclude(typeof(AllergenStatementSettingsDto))]
    [XmlInclude(typeof(IngredientStatementSettingsDto))]
    [XmlInclude(typeof(AdditionalItemIngredientStatementSettingsDto))]
    [XmlInclude(typeof(MealTypeDto))]
    [XmlInclude(typeof(IngredientStatementItemDto))]
    [XmlInclude(typeof(StatementBaseDto))]
    [XmlInclude(typeof(IngredientStatementDto))]
    [XmlInclude(typeof(AllergenStatementDto))]
    [XmlInclude(typeof(LabelDto))]
    [XmlInclude(typeof(LabelNutrientDto))]
    [XmlInclude(typeof(BrandDto))]
    [XmlInclude(typeof(ConsumerDto))]
    [XmlInclude(typeof(PersonDto))]
    [XmlInclude(typeof(JournalDto))]
    [XmlInclude(typeof(JournalEntryDto))]
    [XmlInclude(typeof(NutrientProfileDto))]
    [XmlInclude(typeof(HeaderTextOptionDto))]
    [XmlInclude(typeof(GroupDto))]
    [XmlInclude(typeof(WorkingNutrientsDto))]
    [XmlInclude(typeof(NutrientTransformDto))]
    [XmlInclude(typeof(ConversionsRootDto))]
    [XmlInclude(typeof(ConversionMapDto))]
    [XmlInclude(typeof(ActivityDto))]
    [XmlInclude(typeof(AuthorityDto))]
    [XmlInclude(typeof(RecommendationProfileDto))]
    [XmlInclude(typeof(RecommendationDto))]
    [XmlInclude(typeof(IngredientSourceDto))]
    [XmlInclude(typeof(LabelRuleDto))]
    [GeneratedCode("svcutil", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public abstract class EshaDto
    {
        private Guid? _idField;

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Guid? Id
        {
            get => _idField;
            set => _idField = value;
        }
    }
}