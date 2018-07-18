using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class ItemAnalysisDto : EshaDto
    {
        private AnalysisDto _analysisField;

        private Guid _foodItemIdField;

        private Guid _targetFoodIdField;

        /// <remarks />
        [XmlElement]
        public Guid FoodItemId
        {
            get => _foodItemIdField;
            set => _foodItemIdField = value;
        }

        /// <remarks />
        [XmlElement]
        public Guid TargetFoodId
        {
            get => _targetFoodIdField;
            set => _targetFoodIdField = value;
        }

        /// <remarks />
        [XmlElement]
        public AnalysisDto Analysis
        {
            get => _analysisField;
            set => _analysisField = value;
        }
    }
}