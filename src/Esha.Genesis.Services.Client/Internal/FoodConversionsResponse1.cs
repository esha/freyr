using System;
using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class FoodConversionsResponse1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public FoodConversionsResponse FoodConversionsResponse;

        public FoodConversionsResponse1()
        {
        }

        public FoodConversionsResponse1(FoodConversionsResponse foodConversionsResponse) => FoodConversionsResponse = foodConversionsResponse;
    }
}