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
    public class NutrientQuantityDto
    {
        private Guid _nutrientIdField;

        private QuantityDto _quantityField;

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