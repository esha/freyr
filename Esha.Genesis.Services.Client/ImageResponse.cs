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
    public class ImageResponse
    {
        private Byte[] _imageField;

        /// <remarks />
        [XmlElement(Namespace = "http://ns.esha.com/2013/genesisapi", DataType = "base64Binary", Order = 0)]
        public Byte[] Image
        {
            get => _imageField;
            set => _imageField = value;
        }
    }
}