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
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class NewFoodResponse
    {
        private Int32 _addedFoodsCountField;

        private EditError[] _errorsField;

        private FoodDto[] _foodsField;

        private String _responseVersionField;

        private ResultStatus _statusField;

        /// <remarks />
        [XmlElement]
        public Int32 AddedFoodsCount
        {
            get => _addedFoodsCountField;
            set => _addedFoodsCountField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Error", IsNullable = false)]
        public EditError[] Errors
        {
            get => _errorsField;
            set => _errorsField = value;
        }

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