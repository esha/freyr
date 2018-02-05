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
    public class LabelNutrientDto : EshaDto
    {
        private Guid? _analysisIdField;

        private DailyValueDto[] _dailyValuesField;

        private String _displayValueField;

        private Guid _nutrientIdField;

        private AmountDto _rawValueField;

        private AmountDto _roundedValueField;

        /// <remarks />
        [XmlElement]
        public Guid NutrientId
        {
            get => _nutrientIdField;
            set => _nutrientIdField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Guid? AnalysisId
        {
            get => _analysisIdField;
            set => _analysisIdField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("DailyValue")]
        public DailyValueDto[] DailyValues
        {
            get => _dailyValuesField;
            set => _dailyValuesField = value;
        }

        /// <remarks />
        [XmlElement]
        public String DisplayValue
        {
            get => _displayValueField;
            set => _displayValueField = value;
        }

        /// <remarks />
        [XmlElement]
        public AmountDto RoundedValue
        {
            get => _roundedValueField;
            set => _roundedValueField = value;
        }

        /// <remarks />
        [XmlElement]
        public AmountDto RawValue
        {
            get => _rawValueField;
            set => _rawValueField = value;
        }
    }
}