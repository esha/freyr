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
    [XmlType(Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class PropertyFilter
    {
        private String _propertyUriField;

        private String _valueField;

        /// <remarks />
        [XmlElement]
        public String PropertyUri
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