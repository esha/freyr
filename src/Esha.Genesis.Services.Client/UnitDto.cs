using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class UnitDto : EshaDto
    {
        private GlobalString[] _abbreviationField;

        private Dimension _dimensionField;

        private GlobalString[] _nameField;

        private StandardUnits? _standardKeyField;

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] Abbreviation
        {
            get => _abbreviationField;
            set => _abbreviationField = value;
        }

        /// <remarks />
        [XmlElement]
        public Dimension Dimension
        {
            get => _dimensionField;
            set => _dimensionField = value;
        }

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
        public StandardUnits? StandardKey
        {
            get => _standardKeyField;
            set => _standardKeyField = value;
        }
    }
}