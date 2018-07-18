using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
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