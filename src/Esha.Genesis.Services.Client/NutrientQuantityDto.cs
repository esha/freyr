using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
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