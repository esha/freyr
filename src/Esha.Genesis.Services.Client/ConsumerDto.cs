using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [XmlInclude(typeof(PersonDto))]
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public abstract class ConsumerDto : EshaDto
    {
        private BrandDto _brandField;

        private GlobalString[] _commonNameField;

        private XmlDateTimeOffset _createdField;

        private GlobalString[] _descriptionField;

        private Int32? _eshaCodeField;

        private Guid[] _groupsIdsField;

        private JournalDto _journalField;

        private Int32? _legacyKeyField;

        private XmlDateTimeOffset _modifiedField;

        private GlobalString[] _nameField;

        private String _userCodeField;

        /// <remarks />
        [XmlElement]
        public XmlDateTimeOffset Created
        {
            get => _createdField;
            set => _createdField = value;
        }

        /// <remarks />
        [XmlElement]
        public XmlDateTimeOffset Modified
        {
            get => _modifiedField;
            set => _modifiedField = value;
        }

        /// <remarks />
        [XmlElement]
        public BrandDto Brand
        {
            get => _brandField;
            set => _brandField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] CommonName
        {
            get => _commonNameField;
            set => _commonNameField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Int32? EshaCode
        {
            get => _eshaCodeField;
            set => _eshaCodeField = value;
        }

        /// <remarks />
        [XmlElement]
        public String UserCode
        {
            get => _userCodeField;
            set => _userCodeField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Int32? LegacyKey
        {
            get => _legacyKeyField;
            set => _legacyKeyField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] Description
        {
            get => _descriptionField;
            set => _descriptionField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Id", IsNullable = false)]
        public Guid[] GroupsIds
        {
            get => _groupsIdsField;
            set => _groupsIdsField = value;
        }

        /// <remarks />
        [XmlElement]
        public JournalDto Journal
        {
            get => _journalField;
            set => _journalField = value;
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