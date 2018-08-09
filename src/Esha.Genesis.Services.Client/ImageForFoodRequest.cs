using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi/label/image")]
    public class ImageForFoodRequest
    {
        private FoodDto _foodField;

        /// <remarks />
        [XmlElement(typeof(IngredientDto), ElementName = "Ingredient", IsNullable = true)]
        [XmlElement(typeof(RecipeDto), ElementName = "Recipe", IsNullable = true)]
        public FoodDto Food
        {
            get => _foodField;
            set => _foodField = value;
        }
    }
}