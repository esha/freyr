using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class NewFoodRequest
    {
        private FoodDto[] _foodsField;

        private NutrientProfileDto[] _nutrientProfilesField;

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Ingredient", typeof(IngredientDto), IsNullable = true)]
        [XmlArrayItem("Recipe", typeof(RecipeDto), IsNullable = true)]
        public FoodDto[] Foods
        {
            get => _foodsField;
            set => _foodsField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("NutrientProfile")]
        public NutrientProfileDto[] NutrientProfiles
        {
            get => _nutrientProfilesField;
            set => _nutrientProfilesField = value;
        }
    }
}