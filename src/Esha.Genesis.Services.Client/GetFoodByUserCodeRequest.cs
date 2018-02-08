using System;
using System.CodeDom.Compiler;
using System.Diagnostics;
using System.Xml.Serialization;

namespace Esha.Genesis.Services.Client {
    /// <remarks/>
    [GeneratedCode("svcutil", "4.6.1055.0")]
    [Serializable]
    [DebuggerStepThrough]
    [XmlType(AnonymousType = true, Namespace = "http://ns.esha.com/2013/genesisapi")]
    public class GetFoodByUserCodeRequest 
    {
        /// <remarks/>
        [XmlElement(Order = 0)]
        public String UserCode { get; set; }
    }
}
