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
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class FoodsByPropertyRequest
    {
        private FoodType[] _filterByFoodTypesField;

        private PublicationState[] _filterByPublicationStatesField;

        private String[] _hasPropertiesField;

        private Int32? _pageSizeField;

        private PropertyFilter[] _propertyFiltersField;

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
        [XmlArrayItem("PropertyUri", IsNullable = false)]
        public String[] HasProperties
        {
            get => _hasPropertiesField;
            set => _hasPropertiesField = value;
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
        [XmlArrayItem("Filter", IsNullable = false)]
        public PropertyFilter[] PropertyFilters
        {
            get => _propertyFiltersField;
            set => _propertyFiltersField = value;
        }
    }
}