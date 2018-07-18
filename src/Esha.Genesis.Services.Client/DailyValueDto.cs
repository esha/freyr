using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class DailyValueDto
    {
        private AuthorityDto _authorityField;

        private String _displayValueField;

        private Double _percentageField;

        private Guid _recommendationProfileIdField;

        /// <remarks />
        [XmlElement]
        public AuthorityDto Authority
        {
            get => _authorityField;
            set => _authorityField = value;
        }

        /// <remarks />
        [XmlElement]
        public Guid RecommendationProfileId
        {
            get => _recommendationProfileIdField;
            set => _recommendationProfileIdField = value;
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
        public Double Percentage
        {
            get => _percentageField;
            set => _percentageField = value;
        }
    }
}