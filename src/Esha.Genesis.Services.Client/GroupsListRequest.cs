using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class GroupsListRequest
    {
        private Guid?[] _filterByGroupIdsField;

        private Int32? _pageSizeField;

        private Int32? _startIndexField;

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("GroupId")]
        public Guid?[] FilterByGroupIds
        {
            get => _filterByGroupIdsField;
            set => _filterByGroupIdsField = value;
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