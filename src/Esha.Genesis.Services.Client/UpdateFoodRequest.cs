using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class UpdateFoodRequest
    {
        private IngredientsEditDto[] _ingredientsEditsField;

        private RecipeEditDto[] _recipeEditsField;

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("IngredientsEdit")]
        public IngredientsEditDto[] IngredientsEdits
        {
            get => _ingredientsEditsField;
            set => _ingredientsEditsField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("RecipeEdit")]
        public RecipeEditDto[] RecipeEdits
        {
            get => _recipeEditsField;
            set => _recipeEditsField = value;
        }
    }
}