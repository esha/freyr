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
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class BrandDto : EshaDto
    {
        private String _productField;

        private String _supplierField;

        /// <remarks />
        [XmlElement]
        public String Supplier
        {
            get => _supplierField;
            set => _supplierField = value;
        }

        /// <remarks />
        [XmlElement]
        public String Product
        {
            get => _productField;
            set => _productField = value;
        }
    }
}