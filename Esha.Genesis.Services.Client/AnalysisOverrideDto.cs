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