using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class EditCallerDto
    {
        private String _nameField;

        /// <remarks />
        public String Name
        {
            get => _nameField;
            set => _nameField = value;
        }
    }
}