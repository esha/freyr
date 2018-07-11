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
    public class UpdateFoodResponse1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi")]
        public UpdateFoodResponse UpdateFoodResponse;

        public UpdateFoodResponse1()
        {
        }

        public UpdateFoodResponse1(UpdateFoodResponse updateFoodResponse) => UpdateFoodResponse = updateFoodResponse;
    }
}