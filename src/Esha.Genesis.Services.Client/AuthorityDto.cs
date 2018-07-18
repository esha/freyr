using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class AuthorityDto : EshaDto
    {
        private String _iso3166Alpha2Field;

        private String _iso3166Alpha3Field;

        private Int32? _iso3166NumericField;

        private GlobalString[] _nameField;

        /// <remarks />
        [XmlElement]
        public String Iso3166Alpha2
        {
            get => _iso3166Alpha2Field;
            set => _iso3166Alpha2Field = value;
        }

        /// <remarks />
        [XmlElement]
        public String Iso3166Alpha3
        {
            get => _iso3166Alpha3Field;
            set => _iso3166Alpha3Field = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Int32? Iso3166Numeric
        {
            get => _iso3166NumericField;
            set => _iso3166NumericField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] Name
        {
            get => _nameField;
            set => _nameField = value;
        }
    }
}