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
    public class ConversionMapDto : EshaDto
    {
        private ConversionDto[] _conversionsField;

        private Guid? _parentIdField;

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Conversion")]
        public ConversionDto[] Conversions
        {
            get => _conversionsField;
            set => _conversionsField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Guid? ParentId
        {
            get => _parentIdField;
            set => _parentIdField = value;
        }
    }
}