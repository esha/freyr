using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class FoodsByNameRequest
    {
        private String[] _dataSourceFilterField;
        private FoodType[] _filterByFoodTypesField;

        private PublicationState[] _filterByPublicationStatesField;

        private String _foodNameField;

        private Int32? _pageSizeField;

        private Int32? _startIndexField;

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
        public String FoodName
        {
            get => _foodNameField;
            set => _foodNameField = value;
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