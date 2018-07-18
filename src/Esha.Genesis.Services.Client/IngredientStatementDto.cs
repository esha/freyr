using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
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