using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class UpdateFoodResponse
    {
        private EditError[] _errorsField;

        private String _responseVersionField;

        private ResultStatus _statusField;

        private Int32 _updatedFoodsCountField;

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Error", IsNullable = false)]
        public EditError[] Errors
        {
            get => _errorsField;
            set => _errorsField = value;
        }

        /// <remarks />
        [XmlElement]
        public Int32 UpdatedFoodsCount
        {
            get => _updatedFoodsCountField;
            set => _updatedFoodsCountField = value;
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