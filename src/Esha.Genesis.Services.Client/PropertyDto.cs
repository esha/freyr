using System;
using System.Diagnostics;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class PropertyDto
    {
        private XName[] _domainsField;

        private XName _nameField;

        private XName[] _rangesField;

        private PropertyDto _subPropertyOfField;

        public XName[] Domains
        {
            get => _domainsField;
            set => _domainsField = value;
        }

        public XName[] Ranges
        {
            get => _rangesField;
            set => _rangesField = value;
        }

        public XName Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        public PropertyDto SubPropertyOf
        {
            get => _subPropertyOfField;
            set => _subPropertyOfField = value;
        }
    }
}