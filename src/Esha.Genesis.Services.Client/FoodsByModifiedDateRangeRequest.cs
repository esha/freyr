using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class FoodsByModifiedDateRangeRequest
    {
        private String[] _dataSourceFilterField;
        private XmlDateTimeOffset _endField;

        private FoodType[] _filterByFoodTypesField;

        private PublicationState[] _filterByPublicationStatesField;

        private Int32? _pageSizeField;

        private XmlDateTimeOffset _startField;

        private Int32? _startIndexField;

        /// <remarks />
        [XmlElement]
        public XmlDateTimeOffset Start
        {
            get => _startField;
            set => _startField = value;
        }

        /// <remarks />
        [XmlElement]
        public XmlDateTimeOffset End
        {
            get => _endField;
            set => _endField = value;
        }

        /// <remarks />
        [XmlArray]
        public FoodType[] FilterByFoodTypes
        {
            get => _filterByFoodTypesField;
            set => _filterByFoodTypesField = value;
        }

        /// <remarks />
        [XmlArray]
        public PublicationState[] FilterByPublicationStates
        {
            get => _filterByPublicationStatesField;
            set => _filterByPublicationStatesField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("DataSource")]
        public String[] DataSourceFilter
        {
            get => _dataSourceFilterField;
            set => _dataSourceFilterField = value;
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