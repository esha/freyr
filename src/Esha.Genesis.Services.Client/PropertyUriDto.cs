using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class PropertyUriDto
    {
        private Uri _value;

        /// <remarks />
        public PropertyUriDto()
        {
        }

        /// <remarks />
        public PropertyUriDto(Uri value) => _value = value;

        /// <remarks />
        public String Value
        {
            get => _value?.ToString();
            set => _value = new Uri(value);
        }

        /// <remarks />
        public override string ToString() => Value;
    }
}
