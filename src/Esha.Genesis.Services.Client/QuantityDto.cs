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
    public class QuantityDto
    {
        private QuantityType _typeField;

        private String _valueField;

        /// <remarks />
        [XmlAttribute]
        public QuantityType Type
        {
            get => _typeField;
            set => _typeField = value;
        }

        /// <remarks />
        [XmlText]
        public String Value
        {
            get => _valueField;
            set => _valueField = value;
        }
    }
}