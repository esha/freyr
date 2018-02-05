using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [GeneratedCode("svcutil", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [DesignerCategory("code")]
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