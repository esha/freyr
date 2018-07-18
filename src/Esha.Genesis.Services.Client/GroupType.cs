using System;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public enum GroupType
    {
        /// <remarks />
        Allergen,

        /// <remarks />
        Food,

        /// <remarks />
        Nutrient,

        /// <remarks />
        Consumer,

        /// <remarks />
        Haccp,

        /// <remarks />
        Archive
    }
}