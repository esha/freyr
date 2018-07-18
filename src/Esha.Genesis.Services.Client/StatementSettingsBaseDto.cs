using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [XmlInclude(typeof(AllergenStatementSettingsDto))]
    [XmlInclude(typeof(IngredientStatementSettingsDto))]
    [XmlInclude(typeof(AdditionalItemIngredientStatementSettingsDto))]
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class StatementSettingsBaseDto : EshaDto
    {
        private AuthorityDto _authorityField;

        private XmlDateTimeOffset _createdField;

        private Guid _foodIdField;

        private XmlDateTimeOffset _modifiedField;

        /// <remarks />
        [XmlElement]
        public AuthorityDto Authority
        {
            get => _authorityField;
            set => _authorityField = value;
        }

        /// <remarks />
        [XmlElement]
        public Guid FoodId
        {
            get => _foodIdField;
            set => _foodIdField = value;
        }

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
    }
}