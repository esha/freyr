using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class AmountDto
    {
        private QuantityDto _quantityField;

        private Guid? _unitIdField;

        /// <remarks />
        [XmlElement]
        public QuantityDto Quantity
        {
            get => _quantityField;
            set => _quantityField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Guid? UnitId
        {
            get => _unitIdField;
            set => _unitIdField = value;
        }
    }
}