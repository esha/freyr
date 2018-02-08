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
    public class JournalEntryDto : EshaDto
    {
        private XmlDateTimeOffset _occurredField;

        /// <remarks />
        [XmlElement]
        public XmlDateTimeOffset Occurred
        {
            get => _occurredField;
            set => _occurredField = value;
        }
    }
}