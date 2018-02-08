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
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi/label/image")]
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