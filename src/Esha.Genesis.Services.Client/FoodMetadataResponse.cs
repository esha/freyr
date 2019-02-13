using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class FoodMetadataResponse
    {
        private FoodDto _foodField;

        private FoodDto[] _foodItemsField;

        private NutrientProfileDto _nutrientProfilesField;

        private String _responseVersionField;

        private ResultStatus _statusField;

        /// <remarks />
        [XmlElement("Ingredient", typeof(IngredientDto))]
        [XmlElement("Recipe", typeof(RecipeDto))]
        [XmlElement("CompositeIngredient", typeof(CompositeIngredientDto))]
        public FoodDto Food
        {
            get => _foodField;
            set => _foodField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Ingredient", typeof(IngredientDto), IsNullable = true)]
        [XmlArrayItem("Recipe", typeof(RecipeDto), IsNullable = true)]
        [XmlArrayItem("CompositeIngredient", typeof(CompositeIngredientDto), IsNullable = true)]
        public FoodDto[] FoodItems
        {
            get => _foodItemsField;
            set => _foodItemsField = value;
        }

        /// <remarks />
        [XmlElement]
        public NutrientProfileDto NutrientProfile
        {
            get => _nutrientProfilesField;
            set => _nutrientProfilesField = value;
        }

        /// <remarks />
        [XmlElement]
        public ResultStatus Status
        {
            get => _statusField;
            set => _statusField = value;
        }

        /// <remarks />
        [XmlElement]
        public String ResponseVersion
        {
            get => _responseVersionField;
            set => _responseVersionField = value;
        }
    }
}