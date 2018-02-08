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
    public class RecommendationDto : EshaDto
    {
        private Guid _nutrientIdField;

        private QuantityDto _rangeHighValueField;

        private QuantityDto _rangeLowValueField;

        private RecommendationType _recommendationTypeField;

        private QuantityDto _recommendedValueField;

        /// <remarks />
        [XmlElement]
        public Guid NutrientId
        {
            get => _nutrientIdField;
            set => _nutrientIdField = value;
        }

        /// <remarks />
        [XmlElement]
        public QuantityDto RecommendedValue
        {
            get => _recommendedValueField;
            set => _recommendedValueField = value;
        }

        /// <remarks />
        [XmlElement]
        public QuantityDto RangeHighValue
        {
            get => _rangeHighValueField;
            set => _rangeHighValueField = value;
        }

        /// <remarks />
        [XmlElement]
        public QuantityDto RangeLowValue
        {
            get => _rangeLowValueField;
            set => _rangeLowValueField = value;
        }

        /// <remarks />
        [XmlElement]
        public RecommendationType RecommendationType
        {
            get => _recommendationTypeField;
            set => _recommendationTypeField = value;
        }
    }
}