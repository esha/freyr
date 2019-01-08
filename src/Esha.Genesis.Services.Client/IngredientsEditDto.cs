using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class IngredientsEditDto
    {
        private EditDetailsDto _editDetailsField;
        private IngredientDto[] _ingredientsField;

        private NutrientProfileDto _nutrientProfileField;

        [XmlArray("Ingredients")]
        [XmlArrayItem("Ingredient")]
        public IngredientDto[] Ingredients
        {
            get => _ingredientsField;
            set => _ingredientsField = value;
        }

        public NutrientProfileDto NutrientProfile
        {
            get => _nutrientProfileField;
            set => _nutrientProfileField = value;
        }

        /// <remarks />
        public EditDetailsDto EditDetails
        {
            get => _editDetailsField;
            set => _editDetailsField = value;
        }
    }
}