using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class UpdateFoodRequest1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public UpdateFoodRequest UpdateFoodRequest;

        public UpdateFoodRequest1()
        {
        }

        public UpdateFoodRequest1(UpdateFoodRequest updateFoodRequest) => UpdateFoodRequest = updateFoodRequest;
    }
}