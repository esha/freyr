using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class AllergenStatementSettingsDto : StatementSettingsBaseDto
    {
        private GlobalString[] _overrideTextField;

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Value", Namespace = "http://ns.esha.com/2013/types", IsNullable = false)]
        public GlobalString[] OverrideText
        {
            get => _overrideTextField;
            set => _overrideTextField = value;
        }
    }
}