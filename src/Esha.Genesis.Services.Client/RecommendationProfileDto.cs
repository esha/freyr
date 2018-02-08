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
    public class RecommendationProfileDto : EshaDto
    {
        private ActivityLevel? _activityLevelField;

        private Int32? _ageHighDaysField;

        private Int32? _ageLowDaysField;

        private AuthorityDto _authorityField;

        private Gender? _genderField;

        private Double? _heightCentimetersField;

        private GlobalString[] _nameField;

        private RecommendationDto[] _recommendationsField;

        private Double? _weightKilogramsField;

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Double? HeightCentimeters
        {
            get => _heightCentimetersField;
            set => _heightCentimetersField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Double? WeightKilograms
        {
            get => _weightKilogramsField;
            set => _weightKilogramsField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public ActivityLevel? ActivityLevel
        {
            get => _activityLevelField;
            set => _activityLevelField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Gender? Gender
        {
            get => _genderField;
            set => _genderField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Int32? AgeHighDays
        {
            get => _ageHighDaysField;
            set => _ageHighDaysField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Int32? AgeLowDays
        {
            get => _ageLowDaysField;
            set => _ageLowDaysField = value;
        }

        /// <remarks />
        [XmlElement]
        public AuthorityDto Authority
        {
            get => _authorityField;
            set => _authorityField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Recommendation")]
        public RecommendationDto[] Recommendations
        {
            get => _recommendationsField;
            set => _recommendationsField = value;
        }
    }
}