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
    public class IngredientStatementItemDto : EshaDto
    {
        private QuantityDto _gramGrossWeightField;

        private QuantityDto _gramNetWeightField;

        private QuantityDto _percentOfParentGrossField;

        private QuantityDto _percentOfParentNetField;

        private QuantityDto _percentOfRootGrossField;

        private QuantityDto _percentOfRootNetField;

        private String _subItemGroupEndDelimiterField;

        private String _subItemGroupStartDelimiterField;

        private IngredientStatementItemDto[] _subItemsField;

        private GlobalString[] _textField;

        /// <remarks />
        [XmlElement]
        public QuantityDto GramGrossWeight
        {
            get => _gramGrossWeightField;
            set => _gramGrossWeightField = value;
        }

        /// <remarks />
        [XmlElement]
        public QuantityDto GramNetWeight
        {
            get => _gramNetWeightField;
            set => _gramNetWeightField = value;
        }

        /// <remarks />
        [XmlElement]
        public QuantityDto PercentOfRootGross
        {
            get => _percentOfRootGrossField;
            set => _percentOfRootGrossField = value;
        }

        /// <remarks />
        [XmlElement]
        public QuantityDto PercentOfRootNet
        {
            get => _percentOfRootNetField;
            set => _percentOfRootNetField = value;
        }

        /// <remarks />
        [XmlElement]
        public QuantityDto PercentOfParentGross
        {
            get => _percentOfParentGrossField;
            set => _percentOfParentGrossField = value;
        }

        /// <remarks />
        [XmlElement]
        public QuantityDto PercentOfParentNet
        {
            get => _percentOfParentNetField;
            set => _percentOfParentNetField = value;
        }

        /// <remarks />
        [XmlElement]
        public String SubItemGroupStartDelimiter
        {
            get => _subItemGroupStartDelimiterField;
            set => _subItemGroupStartDelimiterField = value;
        }

        /// <remarks />
        [XmlElement]
        public String SubItemGroupEndDelimiter
        {
            get => _subItemGroupEndDelimiterField;
            set => _subItemGroupEndDelimiterField = value;
        }

        /// <remarks />
        [XmlArray]
        public IngredientStatementItemDto[] SubItems
        {
            get => _subItemsField;
            set => _subItemsField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] Text
        {
            get => _textField;
            set => _textField = value;
        }
    }
}