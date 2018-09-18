using System;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client
{
    /// <remarks />
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class ImageByFoodIdRequest
    {
        /// <remarks />
        [XmlElement(Namespace = "http://ns.esha.com/2013/genesisapi", Order = 0)]
        public Guid? FoodId { get; set; }
    }
}