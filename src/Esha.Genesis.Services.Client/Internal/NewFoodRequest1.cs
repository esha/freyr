using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class NewFoodRequest1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public NewFoodRequest NewFoodRequest;

        public NewFoodRequest1()
        {
        }

        public NewFoodRequest1(NewFoodRequest newFoodRequest) => NewFoodRequest = newFoodRequest;
    }
}