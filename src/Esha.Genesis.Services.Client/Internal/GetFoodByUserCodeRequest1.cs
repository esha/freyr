using System;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class GetFoodByUserCodeRequest1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi", Order = 0)]
        public GetFoodByUserCodeRequest GetFoodByUserCodeRequest;

        public GetFoodByUserCodeRequest1()
        {
        }

        public GetFoodByUserCodeRequest1(GetFoodByUserCodeRequest getFoodByUserCodeRequest) => GetFoodByUserCodeRequest = getFoodByUserCodeRequest;
    }
}