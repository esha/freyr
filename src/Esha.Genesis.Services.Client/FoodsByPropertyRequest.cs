using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class FoodsByPropertyRequest
    {
        private String[] _dataSourceFilterField;
        private FoodType[] _filterByFoodTypesField;

        private PublicationState[] _filterByPublicationStatesField;

        private PropertyUriDto[] _propertyFilterField;

        private Int32? _pageSizeField;

        private PropertyValue[] _propertyValueFilterField;

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
        [XmlArray]
        [XmlArrayItem("PropertyUri", IsNullable = false)]
        public PropertyUriDto[] PropertyFilter
        {
            get => _propertyFilterField;
            set => _propertyFilterField = value;
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

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("PropertyValue", IsNullable = false)]
        public PropertyValue[] PropertyValueFilter
        {
            get => _propertyValueFilterField;
            set => _propertyValueFilterField = value;
        }
    }
}