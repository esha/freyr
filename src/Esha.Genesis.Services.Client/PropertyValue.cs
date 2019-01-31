using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class PropertyValue
    {
        private PropertyUriDto _propertyUriField;

        private String _valueField;

        /// <remarks />
        [XmlElement]
        public PropertyUriDto PropertyUri
        {
            get => _propertyUriField;
            set => _propertyUriField = value;
        }

        /// <remarks />
        [XmlElement]
        public String Value
        {
            get => _valueField;
            set => _valueField = value;
        }
    }
}