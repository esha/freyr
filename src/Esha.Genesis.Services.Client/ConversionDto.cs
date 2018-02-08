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
    public class ConversionDto
    {
        private QuantityDto _conversionFactorField;

        private AmountDto _fromField;

        private AmountDto _toField;

        /// <remarks />
        [XmlElement]
        public AmountDto From
        {
            get => _fromField;
            set => _fromField = value;
        }

        /// <remarks />
        [XmlElement]
        public QuantityDto ConversionFactor
        {
            get => _conversionFactorField;
            set => _conversionFactorField = value;
        }

        /// <remarks />
        [XmlElement]
        public AmountDto To
        {
            get => _toField;
            set => _toField = value;
        }
    }
}