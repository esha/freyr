using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class AnalysisOverrideDto
    {
        private AmountDto _amountField;

        private NutrientQuantityDto[] _overridesField;

        /// <remarks />
        [XmlElement]
        public AmountDto Amount
        {
            get => _amountField;
            set => _amountField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Override")]
        public NutrientQuantityDto[] Overrides
        {
            get => _overridesField;
            set => _overridesField = value;
        }
    }
}