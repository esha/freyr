using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [GeneratedCode("svcutil", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class NutrientDto : EshaDto
    {
        private Boolean _isScalarField;

        private Int32? _legacyKeyField;

        private GlobalString[] _nameField;

        private Int32? _precisionField;

        private StandardNutrients? _standardKeyField;

        private Guid? _unitIdField;

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Int32? LegacyKey
        {
            get => _legacyKeyField;
            set => _legacyKeyField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public StandardNutrients? StandardKey
        {
            get => _standardKeyField;
            set => _standardKeyField = value;
        }

        /// <remarks />
        [XmlElement]
        public Boolean IsScalar
        {
            get => _isScalarField;
            set => _isScalarField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Guid? UnitId
        {
            get => _unitIdField;
            set => _unitIdField = value;
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
        public Int32? Precision
        {
            get => _precisionField;
            set => _precisionField = value;
        }
    }
}