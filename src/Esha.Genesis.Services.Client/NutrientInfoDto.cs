using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [GeneratedCode("svcutil", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class NutrientInfoDto
    {
        private QuantityDto _calculatedField;

        private Guid _nutrientIdField;

        private QuantityDto _overriddenField;

        private QuantityDto _quantityField;

        private QuantityDto _unknownField;

        private QuantityDto _weightField;

        /// <remarks />
        [XmlElement]
        public QuantityDto Unknown
        {
            get => _unknownField;
            set => _unknownField = value;
        }

        /// <remarks />
        [XmlElement]
        public QuantityDto Weight
        {
            get => _weightField;
            set => _weightField = value;
        }

        /// <remarks />
        [XmlElement]
        public QuantityDto Overridden
        {
            get => _overriddenField;
            set => _overriddenField = value;
        }

        /// <remarks />
        [XmlElement]
        public QuantityDto Calculated
        {
            get => _calculatedField;
            set => _calculatedField = value;
        }

        /// <remarks />
        [XmlElement]
        public Guid NutrientId
        {
            get => _nutrientIdField;
            set => _nutrientIdField = value;
        }

        /// <remarks />
        [XmlElement]
        public QuantityDto Quantity
        {
            get => _quantityField;
            set => _quantityField = value;
        }
    }
}