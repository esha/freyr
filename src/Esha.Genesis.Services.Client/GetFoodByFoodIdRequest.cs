using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class GetFoodByFoodIdRequest
    {
        /// <remarks />
        [XmlElement(Order = 0)]
        public Guid FoodId { get; set; }
    }
}