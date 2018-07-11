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
    public class FoodUserCodesListResponse1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public FoodUserCodesListResponse FoodUserCodesListResponse;

        public FoodUserCodesListResponse1()
        {
        }

        public FoodUserCodesListResponse1(FoodUserCodesListResponse foodUserCodesListResponse) => FoodUserCodesListResponse = foodUserCodesListResponse;
    }
}