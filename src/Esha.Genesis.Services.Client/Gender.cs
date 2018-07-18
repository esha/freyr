using System;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public enum Gender
    {
        /// <remarks />
        Unspecified,

        /// <remarks />
        Male,

        /// <remarks />
        Female,

        /// <remarks />
        Pregnant,

        /// <remarks />
        Nursing
    }
}