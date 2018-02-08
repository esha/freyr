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
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class LabelDto : EshaDto
    {
        private AllergenStatementDto[] _allergenStatementsField;

        private Guid[] _foodsField;

        private IngredientStatementDto[] _ingredientStatementsField;

        private LabelNutrientDto[] _nutrientsField;

        private GlobalString[] _servingSizeCombinedField;

        private GlobalString[] _servingSizeTextField;

        private GlobalString[] _servingSizeWeightField;

        private GlobalString[] _servingsPerContainerField;

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("AllergenStatement")]
        public AllergenStatementDto[] AllergenStatements
        {
            get => _allergenStatementsField;
            set => _allergenStatementsField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Id", IsNullable = false)]
        public Guid[] Foods
        {
            get => _foodsField;
            set => _foodsField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("IngredientStatement")]
        public IngredientStatementDto[] IngredientStatements
        {
            get => _ingredientStatementsField;
            set => _ingredientStatementsField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("LabelNutrient")]
        public LabelNutrientDto[] Nutrients
        {
            get => _nutrientsField;
            set => _nutrientsField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] ServingSizeCombined
        {
            get => _servingSizeCombinedField;
            set => _servingSizeCombinedField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] ServingSizeText
        {
            get => _servingSizeTextField;
            set => _servingSizeTextField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] ServingSizeWeight
        {
            get => _servingSizeWeightField;
            set => _servingSizeWeightField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] ServingsPerContainer
        {
            get => _servingsPerContainerField;
            set => _servingsPerContainerField = value;
        }
    }
}