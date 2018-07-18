using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class SupplementFormulaDto : FoodDto
    {
        private BatchSizeDto _defaultBatchSizeField;

        private AmountDto _defaultServingSizeField;

        /// <remarks />
        [XmlElement]
        public AmountDto DefaultServingSize
        {
            get => _defaultServingSizeField;
            set => _defaultServingSizeField = value;
        }

        /// <remarks />
        [XmlElement]
        public BatchSizeDto DefaultBatchSize
        {
            get => _defaultBatchSizeField;
            set => _defaultBatchSizeField = value;
        }
    }
}