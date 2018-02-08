using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [GeneratedCode("svcutil", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class JournalDto : EshaDto
    {
        private JournalEntryDto[] _journalEntriesField;

        /// <remarks />
        [XmlArray]
        public JournalEntryDto[] JournalEntries
        {
            get => _journalEntriesField;
            set => _journalEntriesField = value;
        }
    }
}