using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class AnalysisDto : EshaDto
    {
        private AmountDto _amountAnalyzedField;

        private AmountTarget _amountTargetField;

        private XmlDateTimeOffset _createdField;

        private NutrientInfoDto[] _grossNutrientValuesField;

        private QuantityDto _grossWeightField;

        private ItemAnalysisDto[] _itemAnalysesField;

        private XmlDateTimeOffset _modifiedField;

        private NutrientInfoDto[] _netNutrientValuesField;

        private QuantityDto _netWeightField;

        private Guid _weightUnitIdField;

        /// <remarks />
        [XmlElement]
        public AmountDto AmountAnalyzed
        {
            get => _amountAnalyzedField;
            set => _amountAnalyzedField = value;
        }

        /// <remarks />
        [XmlElement]
        public XmlDateTimeOffset Created
        {
            get => _createdField;
            set => _createdField = value;
        }

        /// <remarks />
        [XmlElement]
        public XmlDateTimeOffset Modified
        {
            get => _modifiedField;
            set => _modifiedField = value;
        }

        /// <remarks />
        [XmlElement]
        public AmountTarget AmountTarget
        {
            get => _amountTargetField;
            set => _amountTargetField = value;
        }

        /// <remarks />
        [XmlElement]
        public QuantityDto GrossWeight
        {
            get => _grossWeightField;
            set => _grossWeightField = value;
        }

        /// <remarks />
        [XmlElement]
        public QuantityDto NetWeight
        {
            get => _netWeightField;
            set => _netWeightField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("NutrientInfo")]
        public NutrientInfoDto[] GrossNutrientValues
        {
            get => _grossNutrientValuesField;
            set => _grossNutrientValuesField = value;
        }

        /// <remarks />
        [XmlElement]
        public Guid WeightUnitId
        {
            get => _weightUnitIdField;
            set => _weightUnitIdField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("ItemAnalysis")]
        public ItemAnalysisDto[] ItemAnalyses
        {
            get => _itemAnalysesField;
            set => _itemAnalysesField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("NutrientInfo")]
        public NutrientInfoDto[] NetNutrientValues
        {
            get => _netNutrientValuesField;
            set => _netNutrientValuesField = value;
        }
    }
}