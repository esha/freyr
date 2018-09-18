using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class ImageRequest
    {
        private Guid? _foodIdField;

        private String _userCodeField;

        /// <remarks />
        [XmlElement(Namespace = "http://ns.esha.com/2013/genesisapi", IsNullable = true, Order = 0)]
        public Guid? FoodId
        {
            get => _foodIdField;
            set => _foodIdField = value;
        }

        /// <remarks />
        [XmlElement(Namespace = "http://ns.esha.com/2013/genesisapi", Order = 1)]
        public String UserCode
        {
            get => _userCodeField;
            set => _userCodeField = value;
        }
    }
}