using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class DietRecallDto : FoodDto
    {
        private Guid _consumerIdField;

        private XmlDateTimeOffset[] _dateTimeField;

        /// <remarks />
        [XmlElement]
        public Guid ConsumerId
        {
            get => _consumerIdField;
            set => _consumerIdField = value;
        }

        /// <remarks />
        [XmlElement("DateTime")]
        public XmlDateTimeOffset[] DateTime
        {
            get => _dateTimeField;
            set => _dateTimeField = value;
        }
    }
}