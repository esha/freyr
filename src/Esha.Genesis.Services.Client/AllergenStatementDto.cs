using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class AllergenStatementDto : StatementBaseDto
    {
        private Guid[] _allergenGroupsField;

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Id", IsNullable = false)]
        public Guid[] AllergenGroups
        {
            get => _allergenGroupsField;
            set => _allergenGroupsField = value;
        }
    }
}