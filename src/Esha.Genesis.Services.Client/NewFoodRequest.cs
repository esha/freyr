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
        private CompositeIngredientEditDto[] _compositeIngredientEditsField;

        private IngredientsEditDto[] _ingredientsEditsField;

        private RecipeEditDto[] _recipeEditsField;

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("CompositeIngredientEdit")]
        public CompositeIngredientEditDto[] CompositeIngredientEdits
        {
            get => _compositeIngredientEditsField;
            set => _compositeIngredientEditsField = value;
        }

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