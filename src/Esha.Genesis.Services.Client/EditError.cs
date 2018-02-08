using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [GeneratedCode("svcutil", "4.6.1055.0")]
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