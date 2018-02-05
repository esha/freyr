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
    public class ResultStatus
    {
        private Int32 _statusCodeField;

        private String _statusDetailField;

        private StatusMessage _statusMessageField;

        /// <remarks />
        [XmlElement]
        public StatusMessage StatusMessage
        {
            get => _statusMessageField;
            set => _statusMessageField = value;
        }

        /// <remarks />
        [XmlElement]
        public Int32 StatusCode
        {
            get => _statusCodeField;
            set => _statusCodeField = value;
        }

        /// <remarks />
        [XmlElement]
        public String StatusDetail
        {
            get => _statusDetailField;
            set => _statusDetailField = value;
        }
    }
}