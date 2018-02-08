using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [GeneratedCode("svcutil", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [XmlType("GlobalString", AnonymousType = true, Namespace = "http://ns.esha.com/2013/types")]
    public class GlobalString
    {
        private String _langField;

        private String _valueField;

        /// <remarks />
        [XmlAttribute("lang", Form = XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public String Language
        {
            get => _langField;
            set => _langField = value;
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