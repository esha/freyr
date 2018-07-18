using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class AmountCostDto
    {
        private AmountDto _amountField;

        private Decimal _costField;

        /// <remarks />
        [XmlElement]
        public AmountDto Amount
        {
            get => _amountField;
            set => _amountField = value;
        }

        /// <remarks />
        [XmlElement]
        public Decimal Cost
        {
            get => _costField;
            set => _costField = value;
        }
    }
}