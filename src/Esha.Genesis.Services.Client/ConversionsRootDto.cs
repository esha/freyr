using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class ConversionsRootDto : EshaDto
    {
        private ConversionDto[] _conversionsField;

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Conversion")]
        public ConversionDto[] Conversions
        {
            get => _conversionsField;
            set => _conversionsField = value;
        }
    }
}