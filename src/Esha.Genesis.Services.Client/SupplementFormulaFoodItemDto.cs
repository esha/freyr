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
    public class SupplementFormulaFoodItemDto : SupplementFoodItemDto
    {
        private UnitDto _labelClaimUnitField;

        private AmountDto _moistureLossField;

        private AmountDto _percentOverageField;

        /// <remarks />
        [XmlElement]
        public AmountDto MoistureLoss
        {
            get => _moistureLossField;
            set => _moistureLossField = value;
        }

        /// <remarks />
        [XmlElement]
        public AmountDto PercentOverage
        {
            get => _percentOverageField;
            set => _percentOverageField = value;
        }

        /// <remarks />
        [XmlElement]
        public UnitDto LabelClaimUnit
        {
            get => _labelClaimUnitField;
            set => _labelClaimUnitField = value;
        }
    }
}