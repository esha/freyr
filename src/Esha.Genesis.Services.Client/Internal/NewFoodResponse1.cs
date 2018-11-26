using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class NewFoodResponse1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public NewFoodResponse NewFoodResponse;

        public NewFoodResponse1()
        {
        }

        public NewFoodResponse1(NewFoodResponse newFoodResponse) => NewFoodResponse = newFoodResponse;
    }
}