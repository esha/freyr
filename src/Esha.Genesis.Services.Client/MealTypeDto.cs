using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class MealTypeDto : EshaDto
    {
        private GlobalString[] _nameField;

        private StandardMealTypes? _standardKeyField;

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public StandardMealTypes? StandardKey
        {
            get => _standardKeyField;
            set => _standardKeyField = value;
        }
    }
}