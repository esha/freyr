using System;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public enum IngredientStatementCompositionBehavior
    {
        /// <remarks />
        Override,

        /// <remarks />
        Merged,

        /// <remarks />
        Single,

        /// <remarks />
        Expanded,

        /// <remarks />
        Ignore
    }
}