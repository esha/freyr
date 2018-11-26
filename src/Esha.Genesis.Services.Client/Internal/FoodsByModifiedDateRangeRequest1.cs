using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class FoodsByModifiedDateRangeRequest1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public FoodsByModifiedDateRangeRequest FoodsByModifiedDateRangeRequest;

        public FoodsByModifiedDateRangeRequest1()
        {
        }

        public FoodsByModifiedDateRangeRequest1(FoodsByModifiedDateRangeRequest foodsByModifiedDateRangeRequest) =>
            FoodsByModifiedDateRangeRequest = foodsByModifiedDateRangeRequest;
    }
}