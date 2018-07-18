using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class UnitListResponse
    {
        private String _responseVersionField;

        private ResultStatus _statusField;

        private UnitDto[] _unitsField;

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

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Unit")]
        public UnitDto[] Units
        {
            get => _unitsField;
            set => _unitsField = value;
        }
    }
}