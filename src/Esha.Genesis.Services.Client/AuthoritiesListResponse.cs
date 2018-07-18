using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class AuthoritiesListResponse
    {
        private AuthorityDto[] _authoritiesField;

        private String _responseVersionField;

        private ResultStatus _statusField;

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Authority")]
        public AuthorityDto[] Authorities
        {
            get => _authoritiesField;
            set => _authoritiesField = value;
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