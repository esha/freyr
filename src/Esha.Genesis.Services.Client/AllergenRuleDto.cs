using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class AllergenRuleDto
    {
        private AllergenRuleType _allergenRuleTypeField;

        private Guid _authorityIdField;

        /// <remarks />
        [XmlElement]
        public AllergenRuleType AllergenRuleType
        {
            get => _allergenRuleTypeField;
            set => _allergenRuleTypeField = value;
        }

        /// <remarks />
        [XmlElement]
        public Guid AuthorityId
        {
            get => _authorityIdField;
            set => _authorityIdField = value;
        }
    }
}