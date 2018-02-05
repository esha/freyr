using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [XmlInclude(typeof(AdditionalItemIngredientStatementSettingsDto))]
    [GeneratedCode("svcutil", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class IngredientStatementSettingsDto : StatementSettingsBaseDto
    {
        private AdditionalItemIngredientStatementSettingsDto[] _additionalItemsField;

        private IngredientStatementCompositionBehavior _compositionBehaviorField;

        private GlobalString[] _itemsOverrideTextField;

        private GlobalString[] _statementNameOverrideField;

        /// <remarks />
        [XmlArray]
        public AdditionalItemIngredientStatementSettingsDto[] AdditionalItems
        {
            get => _additionalItemsField;
            set => _additionalItemsField = value;
        }

        /// <remarks />
        [XmlElement]
        public IngredientStatementCompositionBehavior CompositionBehavior
        {
            get => _compositionBehaviorField;
            set => _compositionBehaviorField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] ItemsOverrideText
        {
            get => _itemsOverrideTextField;
            set => _itemsOverrideTextField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] StatementNameOverride
        {
            get => _statementNameOverrideField;
            set => _statementNameOverrideField = value;
        }
    }
}