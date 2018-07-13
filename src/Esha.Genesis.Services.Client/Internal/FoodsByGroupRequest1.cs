using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class FoodsByGroupRequest1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public FoodsByGroupRequest FoodsByGroupRequest;

        public FoodsByGroupRequest1()
        {
        }

        public FoodsByGroupRequest1(FoodsByGroupRequest foodsByGroupRequest) => FoodsByGroupRequest = foodsByGroupRequest;
    }
}