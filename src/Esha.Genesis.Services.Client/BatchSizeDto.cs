using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class BatchSizeDto
    {
        private QuantityDto _numberOfContainersField;

        private QuantityDto _servingsPerContainerField;

        /// <remarks />
        [XmlElement]
        public QuantityDto ServingsPerContainer
        {
            get => _servingsPerContainerField;
            set => _servingsPerContainerField = value;
        }

        /// <remarks />
        [XmlElement]
        public QuantityDto NumberOfContainers
        {
            get => _numberOfContainersField;
            set => _numberOfContainersField = value;
        }
    }
}