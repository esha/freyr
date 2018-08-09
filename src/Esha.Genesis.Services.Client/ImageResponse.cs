using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
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