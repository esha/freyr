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
    public class IngredientStatementDto : StatementBaseDto
    {
        private IngredientStatementItemDto[] _itemsField;

        /// <remarks />
        [XmlArray]
        public IngredientStatementItemDto[] Items
        {
            get => _itemsField;
            set => _itemsField = value;
        }
    }
}