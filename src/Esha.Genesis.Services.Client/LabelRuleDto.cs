using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class LabelRuleDto : EshaDto
    {
        private String[] _abbreviationsField;

        private String[] _alternateNamesField;

        private Guid? _associationField;

        private Int32 _indentedField;

        private Boolean _isBoldField;

        private Int32? _labelOrderField;

        private Boolean? _mandatoryField;

        private Int32? _roundingRuleField;

        private Double? _significanceLevelField;

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Abbreviation")]
        public String[] Abbreviations
        {
            get => _abbreviationsField;
            set => _abbreviationsField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Name")]
        public String[] AlternateNames
        {
            get => _alternateNamesField;
            set => _alternateNamesField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Guid? Association
        {
            get => _associationField;
            set => _associationField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Double? SignificanceLevel
        {
            get => _significanceLevelField;
            set => _significanceLevelField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Int32? RoundingRule
        {
            get => _roundingRuleField;
            set => _roundingRuleField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Boolean? Mandatory
        {
            get => _mandatoryField;
            set => _mandatoryField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Int32? LabelOrder
        {
            get => _labelOrderField;
            set => _labelOrderField = value;
        }

        /// <remarks />
        [XmlElement]
        public Int32 Indented
        {
            get => _indentedField;
            set => _indentedField = value;
        }

        /// <remarks />
        [XmlElement]
        public Boolean IsBold
        {
            get => _isBoldField;
            set => _isBoldField = value;
        }
    }
}