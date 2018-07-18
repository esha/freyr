using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class ConditionDto : EshaDto
    {
        private String _claimField;

        private Guid[] _nutrientIdsField;

        /// <remarks />
        [XmlElement]
        public String Claim
        {
            get => _claimField;
            set => _claimField = value;
        }

        /// <remarks />
        [XmlArray]
        [XmlArrayItem("Id", IsNullable = false)]
        public Guid[] NutrientIds
        {
            get => _nutrientIdsField;
            set => _nutrientIdsField = value;
        }
    }
}