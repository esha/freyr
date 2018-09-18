using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class AnalyzeResponse
    {
        private AnalysisDto _analysisField;

        private LabelDto _labelField;

        private String _responseVersionField;

        private ResultStatus _statusField;

        /// <remarks />
        [XmlElement]
        public AnalysisDto Analysis
        {
            get => _analysisField;
            set => _analysisField = value;
        }

        /// <remarks />
        [XmlElement]
        public LabelDto Label
        {
            get => _labelField;
            set => _labelField = value;
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