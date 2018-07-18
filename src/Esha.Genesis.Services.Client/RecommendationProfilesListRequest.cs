using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class RecommendationProfilesListRequest
    {
        private AuthorityDto _forAuthorityField;

        private Int32? _pageSizeField;

        private Int32? _startIndexField;

        /// <remarks />
        [XmlElement]
        public AuthorityDto ForAuthority
        {
            get => _forAuthorityField;
            set => _forAuthorityField = value;
        }

        /// <remarks />
        [XmlElement]
        public Int32? StartIndex
        {
            get => _startIndexField;
            set => _startIndexField = value;
        }

        /// <remarks />
        [XmlElement]
        public Int32? PageSize
        {
            get => _pageSizeField;
            set => _pageSizeField = value;
        }
    }
}