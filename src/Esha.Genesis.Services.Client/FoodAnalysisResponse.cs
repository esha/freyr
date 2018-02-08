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
    public class FoodAnalysisResponse
    {
        private FoodDto _foodField;

        private LabelDto[] _labelsField;

        private String _responseVersionField;

        private ResultStatus _statusField;

        /// <remarks />
        [XmlElement]
        public FoodDto Food
        {
            get => _foodField;
            set => _foodField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Label")]
        public LabelDto[] Labels
        {
            get => _labelsField;
            set => _labelsField = value;
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