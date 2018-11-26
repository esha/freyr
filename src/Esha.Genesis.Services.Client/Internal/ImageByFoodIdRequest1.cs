using System.ComponentModel;
using System.Diagnostics;
using System.ServiceModel;

namespace Esha.Genesis.Services.Client.Internal
{
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public class ImageByFoodIdRequest1
    {
        [MessageBodyMember(Namespace = "http://ns.esha.com/2013/genesisapi", Order = 0)]
        public ImageByFoodIdRequest ImageByFoodIdRequest;

        public ImageByFoodIdRequest1()
        {
        }

        public ImageByFoodIdRequest1(ImageByFoodIdRequest imageByFoodIdRequest) => ImageByFoodIdRequest = imageByFoodIdRequest;
    }
}