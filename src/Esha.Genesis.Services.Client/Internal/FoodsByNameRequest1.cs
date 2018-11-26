using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class FoodsByNameRequest1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public FoodsByNameRequest FoodsByNameRequest;

        public FoodsByNameRequest1()
        {
        }

        public FoodsByNameRequest1(FoodsByNameRequest foodsByNameRequest) => FoodsByNameRequest = foodsByNameRequest;
    }
}