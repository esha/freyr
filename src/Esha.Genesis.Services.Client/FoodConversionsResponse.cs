using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class FoodConversionsResponse
    {
        private ConversionDto[] _conversionsField;

        private String _responseVersionField;

        private ResultStatus _statusField;

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Conversion", Namespace = "http://ns.esha.com/2013/exlx")]
        public ConversionDto[] Conversions
        {
            get => _conversionsField;
            set => _conversionsField = value;
        }

        /// <remarks />
        [XmlElement]
        public ResultStatus Status
        {
            get => _statusField;
            set => _statusField = value;
        }

        /// <remarks />
        [XmlElement]
        public String ResponseVersion
        {
            get => _responseVersionField;
            set => _responseVersionField = value;
        }
    }
}