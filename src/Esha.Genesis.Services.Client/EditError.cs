using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class EditError
    {
        private FoodDto _foodField;

        private String _messageField;

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
        [XmlElement]
        public String Message
        {
            get => _messageField;
            set => _messageField = value;
        }
    }
}