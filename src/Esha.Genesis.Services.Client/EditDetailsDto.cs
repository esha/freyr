using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class EditDetailsDto
    {
        private EditCallerDto _editCallerField;
        private String _editMessageField;

        /// <remarks />
        public String EditMessage
        {
            get => _editMessageField;
            set => _editMessageField = value;
        }

        /// <remarks />
        public EditCallerDto EditCaller
        {
            get => _editCallerField;
            set => _editCallerField = value;
        }
    }
}