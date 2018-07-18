using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class IngredientSourceDto : EshaDto
    {
        private GlobalString[] _nameField;

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] Name
        {
            get => _nameField;
            set => _nameField = value;
        }
    }
}