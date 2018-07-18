using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/types")]
    public class XmlDateTimeOffset
    {
        private DateTime _dateTimeField;

        private Int32 _utcOffsetInMinutesField;

        /// <remarks />
        [XmlElement]
        public DateTime DateTime
        {
            get => _dateTimeField;
            set => _dateTimeField = value;
        }

        /// <remarks />
        [XmlElement]
        public Int32 UtcOffsetInMinutes
        {
            get => _utcOffsetInMinutesField;
            set => _utcOffsetInMinutesField = value;
        }
    }
}