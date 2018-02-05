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
    public class NutrientProfileDto : EshaDto
    {
        private Guid? _conversionMapIdField;

        private ConversionDto[] _conversionsField;

        private AmountDto _definingAmountField;

        private Int32? _legacyRefNumField;

        private GlobalString[] _nameField;

        private NutrientQuantityDto[] _nutrientIdVectorField;

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Guid? ConversionMapId
        {
            get => _conversionMapIdField;
            set => _conversionMapIdField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Conversion")]
        public ConversionDto[] Conversions
        {
            get => _conversionsField;
            set => _conversionsField = value;
        }

        /// <remarks />
        [XmlElement]
        public AmountDto DefiningAmount
        {
            get => _definingAmountField;
            set => _definingAmountField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Int32? LegacyRefNum
        {
            get => _legacyRefNumField;
            set => _legacyRefNumField = value;
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
        [XmlArrayItem("Entry")]
        public NutrientQuantityDto[] NutrientIdVector
        {
            get => _nutrientIdVectorField;
            set => _nutrientIdVectorField = value;
        }
    }
}