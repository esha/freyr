using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [GeneratedCode("svcutil", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class FoodMetadataRequest
    {
        private Guid _foodIdField;

        private String _userCodeField;

        /// <remarks />
        [XmlElement]
        public String UserCode
        {
            get => _userCodeField;
            set => _userCodeField = value;
        }

        /// <remarks />
        [XmlElement]
        public Guid FoodId
        {
            get => _foodIdField;
            set => _foodIdField = value;
        }
    }
}