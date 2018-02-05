using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [GeneratedCode("svcutil", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
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
        public FoodDto Food
        {
            get => _foodField;
            set => _foodField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Ingredient", typeof(IngredientDto), IsNullable = true)]
        [XmlArrayItem("Recipe", typeof(RecipeDto), IsNullable = true)]
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