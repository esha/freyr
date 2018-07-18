using System;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public enum Dimension
    {
        /// <remarks />
        Volume,

        /// <remarks />
        Discrete,

        /// <remarks />
        Weight,

        /// <remarks />
        Bioactive,

        /// <remarks />
        Relative,

        /// <remarks />
        Energy
    }
}