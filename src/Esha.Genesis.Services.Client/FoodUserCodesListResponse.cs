using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class FoodUserCodesListResponse
    {
        private String _responseVersionField;

        private ResultStatus _statusField;

        private String[] _userCodesField;

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

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("UserCode")]
        public String[] UserCodes
        {
            get => _userCodesField;
            set => _userCodesField = value;
        }
    }
}