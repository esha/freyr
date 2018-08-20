using System;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [XmlType(Namespace = "http://ns.esha.com/2013/genesisapi")]
    public enum LabelStyle
    {
        /// <remarks />
        Standard,

        /// <remarks />
        Tabular,

        /// <remarks />
        Linear
    }
}