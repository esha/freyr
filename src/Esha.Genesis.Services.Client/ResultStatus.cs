using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
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