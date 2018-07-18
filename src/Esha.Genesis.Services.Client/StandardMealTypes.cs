using System;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public enum StandardMealTypes
    {
        /// <remarks />
        NoMeal,

        /// <remarks />
        Breakfast,

        /// <remarks />
        MorningSnack,

        /// <remarks />
        Lunch,

        /// <remarks />
        AfternoonSnack,

        /// <remarks />
        Dinner,

        /// <remarks />
        EveningSnack
    }
}