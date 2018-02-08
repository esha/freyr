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
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class UnitListRequest
    {
        private Int32? _pageSizeField;

        private Int32? _startIndexField;

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Int32? StartIndex
        {
            get => _startIndexField;
            set => _startIndexField = value;
        }

        /// <remarks />
        [XmlElement(IsNullable = true)]
        public Int32? PageSize
        {
            get => _pageSizeField;
            set => _pageSizeField = value;
        }
    }
}