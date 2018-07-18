using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(Namespace = "http://ns.esha.com/2013/exlx")]
    public class AdditionalItemIngredientStatementSettingsDto : IngredientStatementSettingsDto
    {
        private QuantityDto _percentWeightField;

        /// <remarks />
        [XmlElement]
        public QuantityDto PercentWeight
        {
            get => _percentWeightField;
            set => _percentWeightField = value;
        }
    }
}