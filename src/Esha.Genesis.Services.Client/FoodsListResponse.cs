﻿using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class FoodsListResponse
    {
        private FoodDto[] _foodsField;

        private String _responseVersionField;

        private ResultStatus _statusField;

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Ingredient", typeof(IngredientDto), IsNullable = true)]
        [XmlArrayItem("Recipe", typeof(RecipeDto), IsNullable = true)]
        [XmlArrayItem("CompositeIngredient", typeof(CompositeIngredientDto), IsNullable = true)]
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