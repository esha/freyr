using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [XmlInclude(typeof(IngredientStatementDto))]
    [XmlInclude(typeof(AllergenStatementDto))]
    [GeneratedCode("svcutil", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public abstract class StatementBaseDto : EshaDto
    {
        private AuthorityDto _authorityField;

        private XmlDateTimeOffset _createdField;

        private String _delimiterField;

        private Boolean _isUserOverriddenField;

        private XmlDateTimeOffset _modifiedField;

        private GlobalString[] _textField;

        /// <remarks />
        [XmlElement]
        public AuthorityDto Authority
        {
            get => _authorityField;
            set => _authorityField = value;
        }

        /// <remarks />
        [XmlElement]
        public Boolean IsUserOverridden
        {
            get => _isUserOverriddenField;
            set => _isUserOverriddenField = value;
        }

        /// <remarks />
        [XmlElement]
        public String Delimiter
        {
            get => _delimiterField;
            set => _delimiterField = value;
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

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] Text
        {
            get => _textField;
            set => _textField = value;
        }
    }
}