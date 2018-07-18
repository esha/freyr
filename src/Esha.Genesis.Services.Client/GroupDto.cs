using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class GroupDto : EshaDto
    {
        private AllergenRuleDto[] _allergenRulesField;

        private Guid[] _consumersField;

        private Guid[] _foodsField;

        private GroupType _groupTypeField;

        private GlobalString[] _nameField;

        private Guid[] _nutrientsField;

        private GlobalString[] _parentGroupNameField;

        private Guid? _parentIdField;

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("AllergenRule")]
        public AllergenRuleDto[] AllergenRules
        {
            get => _allergenRulesField;
            set => _allergenRulesField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Id", IsNullable = false)]
        public Guid[] Consumers
        {
            get => _consumersField;
            set => _consumersField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Id", IsNullable = false)]
        public Guid[] Foods
        {
            get => _foodsField;
            set => _foodsField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Guid? ParentId
        {
            get => _parentIdField;
            set => _parentIdField = value;
        }

        /// <remarks />
        [XmlElement]
        public GroupType GroupType
        {
            get => _groupTypeField;
            set => _groupTypeField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] Name
        {
            get => _nameField;
            set => _nameField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Id", IsNullable = false)]
        public Guid[] Nutrients
        {
            get => _nutrientsField;
            set => _nutrientsField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] ParentGroupName
        {
            get => _parentGroupNameField;
            set => _parentGroupNameField = value;
        }
    }
}