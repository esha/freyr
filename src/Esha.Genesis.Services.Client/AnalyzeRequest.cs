using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class AnalyzeRequest
    {
        private FoodDto _foodField;

        [XmlElement]
        public FoodDto Food
        {
            get => _foodField;
            set => _foodField = value;
        }
    }
}
