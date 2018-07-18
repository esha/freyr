using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class FoodsListResponse1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public FoodsListResponse FoodsListResponse;

        public FoodsListResponse1()
        {
        }

        public FoodsListResponse1(FoodsListResponse foodsListResponse) => FoodsListResponse = foodsListResponse;
    }
}